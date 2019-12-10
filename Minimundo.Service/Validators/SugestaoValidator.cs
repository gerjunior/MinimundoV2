using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class SugestaoValidator : AbstractValidator<Sugestao>
    {
        public SugestaoValidator()
        {
            RuleFor(c => c.CampanhaID)
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} CampanhaID")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} CampanhaID.");

            RuleFor(c => c.FuncionarioID)
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} FuncionarioID")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} FuncionarioID.");

            RuleFor(c => c.Descricao)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Descricao.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Descricao'.")
                .MinimumLength(10).WithMessage($"Inserir no mínimo 10 caracteres para a descrição da sugestão.")
                .MaximumLength(500).WithMessage($"{ValidatorConst.Maximo} Descrição é 500.");
        }
    }
}