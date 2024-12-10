using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Interfaces
{
    public interface IChatSessionCacheService
    {
        Task<List<ChatSessionGetAllDto>> GetAllAsync(CancellationToken cancellationToken);

        Task<ChatSessionGetByIdDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken);
        void Remove(Guid id);
    }
}
