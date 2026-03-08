using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public IArticleRepository ArticleRepository { get; }
        public IAuthorRepository AuthorRepository { get; }

        Task SaveChangesAsync();
    }
}
