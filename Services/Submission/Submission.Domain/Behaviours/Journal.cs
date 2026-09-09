using Articles.Abstractions.Enums;
using Blocks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Domain.Entities
{
    public partial class Journal
    {
        public Article CreateArticle(string title, ArticleType Type, string scope)
        {
            var article = new Article()
            {
                Title = title,
                Type = Type,
                Scope = scope,
                journal = this,
                Stage = ArticleStage.Created
            };
            _articles.Add(article);
            // todo - add domain event later
            return article;
        }
    }
}
