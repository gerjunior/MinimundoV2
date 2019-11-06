using FluentValidation;
using Minimundo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {

        }
    }
}
