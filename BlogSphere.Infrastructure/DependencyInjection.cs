using BlogSphere.Application.Articles;
using BlogSphere.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
                (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<ApplicationDbContext>(op =>
                        op.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));

            services.AddScoped<IArticleRepository, ArticleRepository>();

            return services;
        }
    }
}
