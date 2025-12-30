using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Articles
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty;
        public int AuthorId { get; set; } = new();
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
        public List<string> Tags { get; set; } = new();
        public int Likes { get; set; }
        public bool IsLiked { get; set; }
        public int Comments { get; set; }
        public int Views { get; set; }
        public int ReadTime { get; set; }

    }
}
