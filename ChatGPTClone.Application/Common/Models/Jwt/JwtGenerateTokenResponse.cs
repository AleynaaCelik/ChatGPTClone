using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Jwt
{
    public class JwtGenerateTokenResponse
    {
        public string Token { get; set; }

        public DateTime ExpiresAt { get; set; }

        public JwtGenerateTokenResponse(string token, DateTime expiresAt)
        {
            Token = token;

            ExpiresAt = expiresAt;
        }
    }
}
