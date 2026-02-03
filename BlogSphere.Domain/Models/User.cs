using BlogSphere.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Models
{
    public class User : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Bio { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; }

        public List<Article>? Articles { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
