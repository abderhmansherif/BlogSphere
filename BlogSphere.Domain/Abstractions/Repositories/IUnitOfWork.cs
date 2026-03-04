using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Abstractions.Repositories
{
    public interface IUnitOfWork
    {
        public IArticleRepository ArticleRepository { get; }
        public IAuthorRepository AuthorRepository { get; }

        Task SaveChangesAsync();
    }
}
