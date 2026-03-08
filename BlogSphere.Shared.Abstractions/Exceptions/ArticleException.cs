using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Shared.Abstractions.Exceptions
{
    public abstract class ArticleException: Exception
    {
        protected ArticleException(string message): base(message)
        {
        }
    }
}
