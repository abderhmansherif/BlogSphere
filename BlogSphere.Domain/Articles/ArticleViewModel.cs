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

/*
    id: 1,
    title: 'Getting Started with React Hooks in 2024',
    excerpt: 'Learn how to use React Hooks effectively in your projects. This comprehensive guide covers useState, useEffect, and custom hooks.',
    author: { name: 'Sarah Johnson', avatar: 'S' },
    date: '2 days ago',
    readTime: '8 min read',
    image: 'https://images.unsplash.com/photo-1633356122544-f134324a6cee?w=800&h=400&fit=crop',
    tags: ['React', 'JavaScript', 'Web Development'],
    likes: 234,
    comments: 45
 
 
 */
