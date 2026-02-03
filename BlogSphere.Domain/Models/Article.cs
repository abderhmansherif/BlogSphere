using BlogSphere.Domain.Abstractions;
using BlogSphere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogSphere.Domain.Models
{
    public class Article : Entity
    {
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty; // Markdown or HTML content
        public string CoverImage { get; set; } = string.Empty;
        public int? AuthorId { get; set; }
        public ArticleStatus Status { get; set; } = ArticleStatus.Draft;
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
        public int ReadTime { get; set; }

        [ForeignKey("AuthorId")]
        public User? Author { get; set; }

        public List<ArticleTag>? ArticleTags { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
