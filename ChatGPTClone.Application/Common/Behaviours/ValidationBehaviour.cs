﻿using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTClone.Application.Common.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        // Doğrulayıcıları dependency injection yoluyla al
        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            // Doğrulayıcı yoksa sonraki işleme geç
            if (!_validators.Any())
                return await next();

            var context = new ValidationContext<TRequest>(request);

            // Tüm doğrulayıcıları paralel olarak çalıştır
            var validationTasks = _validators.Select(v => v.ValidateAsync(context, cancellationToken));
            var validationResults = await Task.WhenAll(validationTasks);

            // Hataları topla
            var failures = validationResults
                .Where(r => r.Errors.Any()) //burada sıralama önemli
                .SelectMany(r => r.Errors)
                .ToArray();

            // Hata varsa exception fırlat
            if (failures.Any())
                throw new FluentValidation.ValidationException(failures);

            // Hata yoksa sonraki işleme geç
            return await next();
        }
    }
}
