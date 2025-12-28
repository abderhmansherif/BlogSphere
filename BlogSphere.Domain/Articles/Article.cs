using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Articles
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Content { get; set; } = string.Empty;
        public DateTime DatePublished { get; set; } = DateTime.UtcNow;
        public bool IsPublished { get; set; } = false;
    }
}
