using Articles.Abstractions.Enums;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Application.Features.CreateArticle
{
    public record CreateArticleCommand(int JournalId, string Title, string Scope, ArticleType ArticleType) : IRequest<IdResponse>
    {

    }

    public record IdResponse(int Id)
    {
        
    }

    public class CreateArticleCommandValidator: AbstractValidator<CreateArticleCommand>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(x => x.Scope)
                .NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(x => x.JournalId)
                .GreaterThan(0).WithMessage("Invalid journal id");
        }
    }
}
