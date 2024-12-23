﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.Auth.Commands.RefreshToken
{
    public sealed class AuthRefreshTokenResponse
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }

        public AuthRefreshTokenResponse()
        {

        }

        public AuthRefreshTokenResponse(string token, DateTime expiresAt)
        {
            Token = token;
            ExpiresAt = expiresAt;
        }
    }
}
