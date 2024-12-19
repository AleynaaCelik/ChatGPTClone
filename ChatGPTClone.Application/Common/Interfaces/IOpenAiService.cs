using ChatGPTClone.Application.Common.Models.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Interfaces
{
    public interface IOpenAiService
    {
        Task<OpenAIChatResponse> ChatAsync(OpenAIChatRequest request, CancellationToken cancellationToken);
        Task ChatAsync(OpenAIChatRequest openAIChatRequest, CancellationToken cancellationToken);
    }
}
