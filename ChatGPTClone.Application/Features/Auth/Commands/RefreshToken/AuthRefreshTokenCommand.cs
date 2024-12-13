using ChatGPTClone.Application.Common.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.Auth.Commands.RefreshToken
{
    public class AuthRefreshTokenCommand : IRequest<ResponseDto<AuthRefreshTokenResponse>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public AuthRefreshTokenCommand()
        {

        }

        public AuthRefreshTokenCommand(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
