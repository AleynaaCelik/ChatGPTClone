using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Email
{
    public class EmailVerificationDto
    {
        public string Email { get; set; }
        public string Token { get; set; }

        // Parametreli yapıcı metot
        public EmailVerificationDto(string email, string token)
        {
            Email = email;
            Token = token;
        }

        // Parametresiz yapıcı metot
        public EmailVerificationDto()
        {
        }
    }
}
