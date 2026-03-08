using BlogSphere.Application.Exceptions;
using BlogSphere.Application.Services;
using BlogSphere.Domain.Factories;
using BlogSphere.Domain.Repositories;
using BlogSphere.Shared.Abstractions.Command;
using FluentValidation;

namespace BlogSphere.Application.Commands.CreateArticleCommand
{
    public class CreateArticleCommandHandler : ICommandHandler<CreateArticleCommand>
    {
        private readonly IArticleFactory _factory;
        private readonly IArticleRepository _repository;
        private readonly ISlugGeneratorService _slugGenerator;
        private readonly IValidator<CreateArticleCommand> _validator;

        public CreateArticleCommandHandler(IArticleFactory articleFactory, IArticleRepository articleRepository,
                                           ISlugGeneratorService slugGenerator, IValidator<CreateArticleCommand> validator)
        {
            _factory = articleFactory;
            _repository = articleRepository;
            _slugGenerator = slugGenerator;
            _validator = validator;
        }

        public async Task HandleAsync(CreateArticleCommand command)
        {
            //(string Title, string Content, Guid AuthorId, int ReadTime)
            var results = await _validator.ValidateAsync(command);
            if(!results.IsValid)
            {
                throw new ValidationException(results.Errors);
            }

            var (title, content, authorid, readtime) = command;

            var article = await _repository.GetAsync(title);
            if(article is not null)
            {
                throw new AlreadyExistsArticleException(title);
            }

            var slug = await _slugGenerator.GenerateAsync(title);

            var newArticle = _factory.CreateDraft(Guid.NewGuid(), title, content, slug, readtime, authorid);

            await _repository.InsertAsync(newArticle);
        }
    }
}
