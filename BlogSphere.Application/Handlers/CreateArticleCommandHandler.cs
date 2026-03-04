using Azure.Core;
using BlogSphere.Application.Abstractions;
using BlogSphere.Application.Abstractions.Messaging;
using BlogSphere.Application.Abstractions.Repositories;
using BlogSphere.Application.Commandss;
using BlogSphere.Application.DTOs;
using BlogSphere.Application.Validators;
using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Models;
using FluentValidation;

namespace BlogSphere.Application.Handlers
{
    public class CreateArticleCommandHandler : ICommandHandler<CreateArticleCommand, (int, string)>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IValidator<CreateArticleCommand> _validator;
        private readonly ISlugGenerator _slugGenerator;

        public CreateArticleCommandHandler(IArticleRepository articleRepository, 
                                            ITagRepository tagRepository,
                                            IValidator<CreateArticleCommand> validator, 
                                            ISlugGenerator slugGenerator)
        {
            _articleRepository = articleRepository;
            _tagRepository = tagRepository;
            _validator = validator;
            _slugGenerator = slugGenerator;
        }
        public async Task<(int, string)> HandleAsync(CreateArticleCommand command)
        {
            //Validate the command (e.g., check for required fields, validate slug format, etc.)
            var result = await _validator.ValidateAsync(command);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            //Generate slug by article title
            var slug = await _slugGenerator.GenerateAsync(command.Title);

            //make sure to make unique slug by appending a number if the slug already exists in the database
            int counter = 1;
            var baseSlug = slug;
            while (await _tagRepository.SlugExistsAsync(slug))
            {
                slug = baseSlug + $"-{counter}";
                counter++;
            }

            var article = new Article()
            {
                Title = command.Title,
                Slug = slug,
                Content = command.Content,
                CoverImage = command.CoverImage,
                ReadTime = command.ReadTime,
                CreatedAt = DateTime.UtcNow,
                Status = ArticleStatus.Draft, // Default to Draft, can be updated later
                AuthorId = command.AuthorId,
            };

            //Insert the article into the database
            await _articleRepository.InsertAsync(article);

            //Insert the article tags into the database
            var tagNames = command.Tags
                                    .Where(x => !string.IsNullOrWhiteSpace(x))
                                    .Select(x => x.Trim().ToLower())
                                    .Distinct()
                                    .ToList();

            var existingTags = await _tagRepository.GetTagsByNamesAsync(tagNames);

            var tagsToAttach = new List<Tag>();

            var newTags = new List<Tag>();

            if(tagNames.Count > 0)
            {
                foreach (var name in tagNames)
                {
                    if (existingTags.TryGetValue(name, out Tag? tag))
                    {
                        tagsToAttach.Add(tag);
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            var newTag = new Tag()
                            {
                                Name = name,
                            };
                            tagsToAttach.Add(newTag);
                            newTags.Add(newTag);
                        }

                    }
                }

                //Insert the new tags into the database
                await _tagRepository.InsertItemsAsync(newTags);

                //Associate the tags with the article
                await _tagRepository.InsertArticleTagsAsync(article.Id, tagsToAttach);
            }
           
            return (article.Id ,article.Slug);
        }
    }
}
