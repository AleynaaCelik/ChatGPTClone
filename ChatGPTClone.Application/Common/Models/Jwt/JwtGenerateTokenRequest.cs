using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Jwt
{
    public class JwtGenerateTokenRequest
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public IList<string> Roles { get; set; }

        public JwtGenerateTokenRequest(Guid id, string email, IList<string> roles)
        {
            Id = id;
            Email = email;
            Roles = roles;
        }
    }
}
