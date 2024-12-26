using ChatGPTClone.Application.Common.Interfaces;
using ChatGPTClone.Domain.Entities;
using ChatGPTClone.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, Role, Guid, AppUserClaim, AppUserRole, AppUserLogin, RoleClaim, AppUserToken>, IApplicationDbContext
    {
        public DbSet<ChatSession> ChatSessions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // This method is used to configure the database schema
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
