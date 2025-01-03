﻿using ChatGPTClone.Application.Common.Models.General;
using ChatGPTClone.Application.Common.Models.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Features.Auth.Commands.Register
{
    public class AuthRegisterCommand : IRequest<ResponseDto<AuthRegisterDto>>
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public IdentityRegisterRequest ToIdentityRegisterRequest()
        {
            return new IdentityRegisterRequest(Email, Password, FirstName, LastName);
        }
    }
}
