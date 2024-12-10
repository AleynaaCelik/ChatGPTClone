using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Identity
{
    public class IdentityLoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public IdentityLoginRequest(string email, string password)
        {
            Email = email;

            Password = password;
        }
    }
}
