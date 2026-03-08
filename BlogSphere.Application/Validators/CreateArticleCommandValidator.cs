using BlogSphere.Application.Commands.CreateArticleCommand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Validators
{
    public class CreateArticleCommandValidator: AbstractValidator<CreateArticleCommand>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Article Content is required.");

            RuleFor(x => x.AuthorId)
                .NotEmpty().WithMessage("Author Id is required.");

            RuleFor(x => x.ReadTime)
                .GreaterThan(0).WithMessage("Read Time Cannot be zero");
        }
    }
}
