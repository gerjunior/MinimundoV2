using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class TelefoneValidator : AbstractValidator<Telefone>
    {
        public TelefoneValidator()
        {
            RuleFor(c => c.TelefoneID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} TelefoneID.");

            RuleFor(c => c.UsuarioID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} UsuarioID.");

            RuleFor(c => c.Tipo)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Tipo.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Tipo'.")
                .Must(TipoTelefone).WithMessage($"Tipo de Telefone inválido.");

            RuleFor(c => c.DDD)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} DDD.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'DDD'.")
                .MaximumLength(4).WithMessage("DDD inválido.");

            RuleFor(c => c.DDI)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} DDI.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'DDI'.")
                .MaximumLength(4).WithMessage("DDI inválido.");

            RuleFor(c => c.Numero)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Numero.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Numero'.")
                .Length(9).WithMessage("Numero inválido.");

        }

        public static bool TipoTelefone(char Tipo)
        {
            return Tipo == 'R' || Tipo == 'C' || Tipo == 'P';
        }
    }
}
