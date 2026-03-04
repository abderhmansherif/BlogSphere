using BlogSphere.Application.Abstractions;
using BlogSphere.Application.Abstractions.Messaging;
using BlogSphere.Application.Commandss;
using BlogSphere.Application.Handlers;
using BlogSphere.Application.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BlogSphere.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<ICommandHandler<CreateArticleCommand, (int, string)>, CreateArticleCommandHandler>();
            services.AddTransient<ISlugGenerator, SlugGenerator>();

            return services;
        }
    }
}
