using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class SugestaoAvaliacaoValidator : AbstractValidator<SugestaoAvaliacao>
    {
        public SugestaoAvaliacaoValidator()
        {
            RuleFor(c => c.SugestaoAvaliacaoID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} SugestaoAvaliacaoID.");

            RuleFor(c => c.SugestaoID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} SugestaoID.");

            RuleFor(c => c.Nota)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Nota.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} Nota.")
                .GreaterThanOrEqualTo(0).WithMessage($"A nota não pode ser inferior a 0.")
                .LessThanOrEqualTo(10).WithMessage($"A nota não pode ser superior a 10.");

            RuleFor(c => c.Informacao)
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Informação é 100.");
        }
    }
}
