using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class AvaliadorValidator : AbstractValidator<Avaliador>
    {
        public AvaliadorValidator()
        {
            RuleFor(c => c.AvaliadorID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} AvaliadorID.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} AvaliadorID.");

            RuleFor(c => c.UsuarioID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} UsuarioID.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} UsuarioID.");
        }
    }
}