
using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Events;
using BlogSphere.Domain.Exceptions;
using BlogSphere.Domain.ValueObjects.Article;
using BlogSphere.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogSphere.Domain.Entities
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

        private readonly List<ArticleTag> _tags = new ();
        private readonly List<ArticleComment> _comments = new ();


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

        private Article()
        { }

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
            if (_status != ArticleStatus.Published)
            {
                throw new CannotArchiveArticleException();
            }

            _archiveAt = DateTime.UtcNow;
            _status = ArticleStatus.Archived;
            AddDomainEvent(new ArticleArchived(this));
        }


        public void AddTag(ArticleTag tag)
        {
            if (_tags.Any(t => t == tag))
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

        public ArticleTag GetTag(string tagName)
        {
            var existingTag = _tags.Find(x => x.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));
            if (existingTag is null)
            {
                throw new NotFoundArticleTagException(tagName);
            }
            return existingTag;
        }

        public void AddComment(ArticleComment comment)
        {
            _comments.Add(comment);
            AddDomainEvent(new ArticleCommentAdded(this, comment));
        }

        public ArticleComment GetComment(string commentContent)
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
