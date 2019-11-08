using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.FuncionarioID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} FuncionarioID.");

            RuleFor(c => c.EmpresaID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} EmpresaID.");

            RuleFor(c => c.UsuarioID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} UsuarioID.");
        }
    }
}