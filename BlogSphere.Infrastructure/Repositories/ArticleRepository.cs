using BlogSphere.Application.Articles;
using BlogSphere.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Infrastructure.Repositories
{
    internal class ArticleRepository(IDbContextFactory<ApplicationDbContext> factory) : IArticleRepository
    {
        public IDbContextFactory<ApplicationDbContext> Factory { get; } = factory;

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            using var context = await Factory.CreateDbContextAsync();
            
            var articles = await context.Articles.ToListAsync();

            return articles;
        }
    }
}
