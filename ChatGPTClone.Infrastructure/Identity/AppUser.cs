using ChatGPTClone.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ChatGPTClone.Infrastructure.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity<Guid>, ICreatedByEntity, IModifiedByEntity // guid kullanmanın sebebi id'nin unique olmasını sağlamak //mysql için guid kullanılmaz(problemli yani)
    { //AppUser bir yere bağımlı olmasın diye infrastructure katmanına koyduk
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public string CreatedByUserId { get; set; }

        public DateTimeOffset? ModifiedOn { get; set; }

        public string? ModifiedByUserId { get; set; }
    }
}
