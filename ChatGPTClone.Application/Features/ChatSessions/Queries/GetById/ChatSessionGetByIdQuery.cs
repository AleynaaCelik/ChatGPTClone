using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.ChatSessions.Queries.GetById
{
    public sealed class ChatSessionGetByIdQuery : IRequest<ChatSessionGetByIdDto>
    {
        public Guid Id { get; set; } //parametre aldığım Id ye göre getireceğim.

        public ChatSessionGetByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
