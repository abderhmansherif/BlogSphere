using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class InvaldiArtilceAuthorIdException: ArticleException
    {
        public InvaldiArtilceAuthorIdException(string value): base($"Invalid article author id: {value}")
        { 
        }
    }
}
