using ChatGPTClone.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.ChatSessions.Queries.GetById
{
    public sealed class ChatSessionGetByIdQueryHandler : IRequestHandler<ChatSessionGetByIdQuery, ChatSessionGetByIdDto>
    {
        private readonly IChatSessionCacheService _chatSessionCacheService;
        public ChatSessionGetByIdQueryHandler(IChatSessionCacheService chatSessionCacheService)
        {
            _chatSessionCacheService = chatSessionCacheService;
        }

        public Task<ChatSessionGetByIdDto> Handle(ChatSessionGetByIdQuery request, CancellationToken cancellationToken)
        {
            return _chatSessionCacheService.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
