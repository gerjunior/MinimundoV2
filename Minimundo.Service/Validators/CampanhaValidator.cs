using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class CampanhaValidator : AbstractValidator<Campanha>
    {
        public CampanhaValidator()
        {
            RuleFor(c => c.EmpresaID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} EmpresaID.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} EmpresaID.");

            RuleFor(c => c.AvaliadorID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} AvaliadorID.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} AvaliadorID.");

            RuleFor(c => c.Responsavel)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Responsavel.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Responsável'.")
                .MaximumLength(100).WithMessage($"Máximo de caracteres: 100.");

            RuleFor(c => c.Nome)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Nome.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Nome'.")
                .MaximumLength(100).WithMessage($"Máximo de caracteres: 100.");

            RuleFor(c => c.Descricao)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Descricao.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Descrição'.")
                .MaximumLength(100).WithMessage($"Máximo de caracteres: 100.");

            RuleFor(c => c.InicioPeriodo)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} InicioPeríodo.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Início do Período'.")
                .LessThanOrEqualTo(f => f.FimPeriodo).WithMessage($"A Data de Início do período não pode ser maior que à data de Fim do Período.");

            RuleFor(c => c.FimPeriodo)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} FimPeriodo.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} Fim do Período.")
                .GreaterThanOrEqualTo(f => f.InicioPeriodo).WithMessage($"A data de Fim do Período não pode ser menor que a data de Início do Período.");

            RuleFor(c => c.ValorPremio)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} ValorPremio.")
                .GreaterThanOrEqualTo(0).WithMessage($"O Valor do Prêmio não pode ser menor que 0.");

            RuleFor(c => c.Status)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Status.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} Status.")
                .Must(Status).WithMessage($"Parâmetro Status incorreto.");
        }

        public static bool Status(char Status)
        {
            return Status == 'A' || Status == 'F';
        }
    }
}