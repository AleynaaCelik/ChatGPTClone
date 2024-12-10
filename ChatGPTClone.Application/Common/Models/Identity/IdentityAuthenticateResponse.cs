using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Models.Identity
{
    public class IdentityAuthenticateResponse
    {
        public string Token { get; set; } //içinde ne zaman biteceği yazacağı için sadece token yazmamız yeterli
    }
}
