using BlogSphere.Application.Commands.CreateArticleCommand;
using BlogSphere.Application.Validators;
using BlogSphere.Domain.Factories;
using BlogSphere.Shared.Abstractions.Command;
using BlogSphere.Shared.Command;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace BlogSphere.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IArticleFactory, ArticleFactory>();
            services.AddScoped<ICommandDispatcher, InMemoryCommandDispatcher>();
            services.AddScoped<IValidator<CreateArticleCommand>, CreateArticleCommandValidator>();
            services.AddCommands();

            return services;
        }
    }
}
