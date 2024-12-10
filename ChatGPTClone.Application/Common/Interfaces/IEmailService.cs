using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task EmailVerificationAsync(EmailVerificationDto emailVerificationDto, CancellationToken cancellationToken);
    }
}
