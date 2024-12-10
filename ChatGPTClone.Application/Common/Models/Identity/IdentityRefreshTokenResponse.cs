using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Identity
{
    public class IdentityRefreshTokenResponse
    {
        public string AccessToken { get; set; }
        public DateTime Expires { get; set; }
        public IdentityRefreshTokenResponse(string accessToken, DateTime expires)
        {
            AccessToken = accessToken;
            Expires = expires;
        }
    }
}
