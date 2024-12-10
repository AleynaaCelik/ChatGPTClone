using ChatGPTClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<ChatSession> ChatSessions { get; set; }
        DbSet<RefreshToken> RefreshTokens { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        int SaveChanges();
    }
}
