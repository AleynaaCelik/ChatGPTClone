using ChatGPTClone.Application.Common.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.Auth.Commands.Register
{
    public class AuthRegisterDto
    {
        public Guid UserId { get; set; }

        public string EmailToken { get; set; }

        public AuthRegisterDto(Guid userId, string emailToken)
        {
            UserId = userId;
            EmailToken = emailToken;
        }

        public static AuthRegisterDto Create(IdentityRegisterResponse response)
        {
            return new AuthRegisterDto(response.Id, response.EmailToken);
        }
    }
}
