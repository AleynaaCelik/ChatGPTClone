using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Identity
{
    public class IdentityCreateEmailTokenResponse
    {
        public string Token { get; set; }

        public IdentityCreateEmailTokenResponse(string token)
        {
            Token = token;
        }
    }
}
