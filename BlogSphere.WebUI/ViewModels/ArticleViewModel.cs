using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty;
        public int AuthorId { get; set; } = new();
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorAvatar { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string PublishedSince { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int ReadTime { get; set; }
        public string Views { get; set; } = string.Empty;
    }
}
