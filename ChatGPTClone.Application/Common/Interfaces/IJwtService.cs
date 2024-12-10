using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Interfaces
{
    public interface IJwtService
    {
        JwtGenerateTokenResponse GenerateToken(JwtGenerateTokenRequest request);

        bool ValidateToken(string token);
        Guid GetUserIdFromJwt(string token);


    }
}
