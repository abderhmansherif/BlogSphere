using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Abstractions.Domain
{
    public abstract class ArticleException: Exception
    {
        protected ArticleException(string message): base(message)
        {
        }
    }
}
