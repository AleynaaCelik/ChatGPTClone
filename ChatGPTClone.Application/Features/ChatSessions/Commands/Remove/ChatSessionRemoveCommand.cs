using ChatGPTClone.Application.Common.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.ChatSessions.Commands.Remove
{
    public class ChatSessionRemoveCommand : IRequest<ResponseDto<Guid>>
    {
        public Guid Id { get; set; }

        public ChatSessionRemoveCommand(Guid id)
        {
            Id = id;
        }

    }
}
