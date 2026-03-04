using BlogSphere.Application.Commandss;
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
                .NotEmpty().WithMessage("the title cannot be empty.")
                .MinimumLength(4).WithMessage("the title should be greater than 4 letters")
                .MaximumLength(100).WithMessage("the title should be less than 100 letters");

            RuleFor(x => x.CoverImage)
                .NotEmpty().WithMessage("the article image is required");

            RuleFor(x => x.ReadTime)
                .GreaterThan(0)
                .NotEmpty().WithMessage("Read time is required");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("the aerticle content cannot be empty.")
                .MaximumLength(10000).WithMessage("the content should be less than 10k letters")
                .MinimumLength(4).WithMessage("the content should be greater than 4 letters");

            RuleFor(x => x.AuthorId)
                .GreaterThan(0).WithMessage("author id is not valid");                
                
        }
    }
}
