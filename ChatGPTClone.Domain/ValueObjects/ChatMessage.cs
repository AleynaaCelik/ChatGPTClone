using ChatGPTClone.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Domain.ValueObjects
{
    public sealed class ChatMessage
    {
        public string Id { get; set; }

        public GptModelType Model { get; set; }

        public ChatMessageType Type { get; set; }

        public string Content { get; set; } //içerik

        public DateTimeOffset CreatedOn { get; set; } //oluşturulma tarihi
    }
}
