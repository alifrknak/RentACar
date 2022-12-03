﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(q => q.Password).NotEmpty();

            RuleFor(q => q.Email).NotEmpty();

            RuleFor(q => q.FirstName).NotEmpty();
        }
    }
}
