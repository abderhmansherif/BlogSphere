//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BlogSphere.Application.Articles
//{
//    public class ArticleService : IArticleService
//    {

//        private List<ArticleViewModel> articles = new List<ArticleViewModel>()
//        {
//            new ArticleViewModel()
//            {
//                Id = 1,
//                Title = "Getting Started with React Hooks in 2024",
//                Content = "Learn how to use React Hooks effectively in your projects. This comprehensive guide covers useState, useEffect, and custom hooks.",
//                AuthorName = "Sarah Johnson",
//                AuthorAvatar = "S",
//                Date = DateTime.UtcNow.AddDays(-2),
//                PublishedSince = "2 days ago",
//                ReadTime = 8,
//                CoverImage = "https://images.unsplash.com/photo-1633356122544-f134324a6cee?w=800&h=400&fit=crop",
//                Tags = new List<string>() { "React", "JavaScript", "Web Development" },
//                Likes = 234,
//                Comments = 45

//            },
//            new ArticleViewModel()
//            {
//                Id = 2,
//                Title = "The Future of Web Development: Trends to Watch",
//                Content = "Explore the emerging trends that are shaping the future of web development, from AI integration to progressive web apps.",
//                AuthorName = "Michael Chen",
//                AuthorAvatar = "M",
//                Date = DateTime.UtcNow.AddDays(-5),
//                PublishedSince = "5 days ago",
//                ReadTime = 12,
//                CoverImage = "https://images.unsplash.com/photo-1517694712202-14dd9538aa97?w=800&h=400&fit=crop",
//                Tags = new List<string>() { "Web Development", "Technology", "Trends" },
//                Likes = 567,
//                Comments = 89
//            },
//            new ArticleViewModel()
//            {
//                Id = 3,
//                Title = "Building Scalable Applications with Microservices",
//                Content = "Discover best practices for designing and implementing microservices architecture in modern applications.",
//                AuthorName = "Emily Rodriguez",
//                AuthorAvatar = "E",
//                Date = DateTime.UtcNow.AddDays(-7),
//                PublishedSince = "1 week ago",
//                ReadTime = 15,
//                CoverImage = "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=800&h=400&fit=crop",
//                Tags = new List<string>() { "Architecture", "Backend", "Microservices" },
//                Likes = 423,
//                Comments = 67
//            },
//            new ArticleViewModel()
//            {
//                Id = 4,
//                Title = "CSS Grid vs Flexbox: When to Use Which",
//                Content = "A practical guide to choosing between CSS Grid and Flexbox for your layout needs.",
//                AuthorName = "David Park",
//                AuthorAvatar = "D",
//                Date = DateTime.UtcNow.AddDays(-7),
//                PublishedSince = "1 week ago",
//                ReadTime = 6,
//                CoverImage = "https://images.unsplash.com/photo-1507721999472-8ed4421c4af2?w=800&h=400&fit=crop",
//                Tags = new List<string>() { "CSS", "Design", "Web Development" },
//                Likes = 189,
//                Comments = 32
//            }
//        };
//        public async Task<ArticleViewModel> GetArticleByIdAsync(int id)
//        {
//            return articles.FirstOrDefault(x => x.Id == id)!;
//        }

//        public async Task<List<ArticleViewModel>> GetArticlesAsync()
//        {
//            return articles;
//        }

//        public async Task<List<ArticleViewModel>> GetTrendingArticlesAsync()
//        {
//            return new List<ArticleViewModel>()
//            { 
//                new ArticleViewModel()
//                {
//                    Id= 1,
//                    Title = "Understanding TypeScript Generics",
//                    AuthorName = "Alex Kim",
//                    Views = "12.5k"
//                },
//                new ArticleViewModel()
//                {
//                    Id = 2,
//                    Title = "Node.js Performance Optimization Tips",
//                    AuthorName = "Lisa Wang",
//                    Views = "9.8k"
//                },
//                new ArticleViewModel()
//                {
//                    Id = 3,
//                    Title = "Modern CSS Techniques Every Developer Should Know",
//                    AuthorName = "Tom Brown",
//                    Views = "'8.2k"
//                },
//                new ArticleViewModel()
//                {
//                    Id = 4,
//                    Title = "Building Real-time Apps with WebSockets",
//                    AuthorName = "Nina Patel",
//                    Views = "7.1k"
//                },
//                new ArticleViewModel()
//                {
//                    Id = 5,
//                    Title = "GraphQL vs REST: A Comprehensive Comparison",
//                    AuthorName = "Chris Lee",
//                    Views = "6.9k"
//                }
//            };
//        }
//    }
//}

