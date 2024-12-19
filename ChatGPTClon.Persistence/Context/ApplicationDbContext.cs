using Abp.Authorization.Roles;
using ChatGPTClone.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.PowerBI.Api.Models;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
namespace ChatGPTClone.Persistence.Context;

public class ApplicationDbContext : IdentityDbContext<AppUser, Role, Guid, AppUserClaim, AppUserRole, AppUserLogin, RoleClaim, AppUserToken>
{
    public DbSet<ChatSession> ChatSessions { get; set; } //ChatSession tablosunu oluşturuyor

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //bu classın constructoru //base classın constructorunu çağırıyor
    {
    }
    protected override void OnModelCreating(ModelBuilder builder) //bu metod tabloları oluştururken tablolar arasındaki ilişkileri belirlemek için kullanılır
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
