using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Application.Features.CreateArticle
{
    internal class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, IdResponse>
    {
        public Task<IdResponse> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
