using Azure;
using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Events;
using BlogSphere.Domain.Exceptions;
using BlogSphere.Domain.ValueObjects.Article;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogSphere.Domain.Models
{
    public class Article : AggregateRoot
    {
        public ArticleId Id { get; private set; }

        private ArticleTitle _title;

        private ArticleSlug _slug;

        private ArticleContent _content;  // Markdown or HTML content

        // public string CoverImage { get; set; } = string.Empty; // Domain don't care about cover it just for UI
        private ArticleAuthorId _authorId;

        private ArticleStatus _status; 

        private DateTime _publishedAt;

        private DateTime _createdAt;

        private DateTime _archiveAt;


        private ArticleReadTime _readTime;

        private readonly List<Tag> _tags = new List<Tag>();
        private readonly List<Comment> _comments = new List<Comment>();


        internal Article(ArticleId id, ArticleTitle title, ArticleSlug slug, ArticleContent content,
                        ArticleAuthorId authorId, ArticleReadTime readTime)
        {
            Id = id;
            _title = title;
            _slug = slug;
            _content = content;
            _authorId = authorId;
            _status = ArticleStatus.Draft;
            _createdAt = DateTime.UtcNow;
            _readTime = readTime;
        }

        public void Publish()
        {
            if(_status == ArticleStatus.Published)
            {
                throw new AlreadyPublishedArticleException(_title.Value);
            }

            _publishedAt = DateTime.UtcNow;
            _status = ArticleStatus.Published;
            AddDomainEvent(new ArticlePublished(this));
        }

        public void Archive()
        {
            if(_status == ArticleStatus.Archived)
            {
                throw new AlreadyArchivedArticleException(_title.Value);
            }

            _archiveAt = DateTime.UtcNow;
            _status = ArticleStatus.Archived;
            AddDomainEvent(new ArticleArchived(this));
        }


        public void AddTag(Tag tag)
        {
            if (_tags.Any(x => x.Name.Equals(tag.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new AlreadyExistArticleTagException(tag.Name);
            }

            _tags.Add(tag);
            AddDomainEvent(new ArticleTagAdded(this, tag));
        }

        public void RemoveTag(string tag)
        {
            var existingTag = _tags.Find(x => x.Name.Equals(tag, StringComparison.OrdinalIgnoreCase));
            
            if(existingTag is null)
            {
                throw new NotFoundArticleTagException(tag);
            }

            _tags.Remove(existingTag);
            AddDomainEvent(new ArticleTagRemoved(this, existingTag));
        }

        public Tag GetTag(string tagName)
        {
            var existingTag = _tags.Find(x => x.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));
            if (existingTag is null)
            {
                throw new NotFoundArticleTagException(tagName);
            }
            return existingTag;
        }

        public void AddComment(Comment comment)
        {
            if (_comments.Any(x => x.Content.Equals(comment.Content, StringComparison.OrdinalIgnoreCase)))
            {
                throw new AlreadyExistArticleCommentException(comment.Content);
            }

            _comments.Add(comment);
            AddDomainEvent(new ArticleCommentAdded(this, comment));
        }

        public Comment GetComment(string commentContent)
        {
            var existingComment = _comments.Find(x => x.Content.Equals(commentContent, StringComparison.OrdinalIgnoreCase));
            if (existingComment is null)
            {
                throw new NotFoundArticleCommentException(commentContent);
            }
            return existingComment;
        }

        public void RemoveComment(string commentContent)
        {
            var existingComment = _comments.Find(x => x.Content.Equals(commentContent, StringComparison.OrdinalIgnoreCase));
            if (existingComment is null)
            {
                throw new NotFoundArticleCommentException(commentContent);
            }
            _comments.Remove(existingComment);
            AddDomainEvent(new ArticleCommentRemoved(this, existingComment));
        }
    }
}
