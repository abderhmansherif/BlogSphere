using BlogSphere.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Articles
{
    public class Article : Entity
    {
        public required string Title { get; set; }
        public string? Content { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
    }
}
