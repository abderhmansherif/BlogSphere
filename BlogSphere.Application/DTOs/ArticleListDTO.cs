

namespace BlogSphere.Application.DTOs
{
    public class ArticleListDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorAvatar { get; set; } = string.Empty;
        public int ReadTime { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
