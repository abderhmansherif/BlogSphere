using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Models
{
    public class ArticleTag
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int? TagId { get; set; }

        public Article? Article { get; set; }
        public Tag? Tag { get; set; }
    }
}
