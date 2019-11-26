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
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} FuncionarioID")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} FuncionarioID.");

            RuleFor(c => c.EmpresaID)
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} EmpresaID")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} EmpresaID.");

            RuleFor(c => c.UsuarioID)
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} UsuarioID")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} UsuarioID.");
        }
    }
}