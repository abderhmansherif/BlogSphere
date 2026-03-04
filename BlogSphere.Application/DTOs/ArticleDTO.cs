

namespace BlogSphere.Application.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty; // Markdown or HTML content
        public string CoverImage { get; set; } = string.Empty;
        public int? AuthorId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime PublishedAt { get; set; }
        public int ReadTime { get; set; }
    }
}
