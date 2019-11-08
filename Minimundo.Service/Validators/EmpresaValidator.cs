using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;
using System.Text.RegularExpressions;

namespace Minimundo.Service.Validators
{
    public class EmpresaValidator : AbstractValidator<Empresa>
    {
        public EmpresaValidator()
        {
            RuleFor(c => c.EmpresaID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} EnderecoID.");

            RuleFor(c => c.NomeFantasia)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} NomeFantasia.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Nome Fantasia'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Nome Fantasia é 100.");

            RuleFor(c => c.CNPJ)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} CNPJ.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'CNPJ'.")
                .Must(ValidatorConst.CNPJ).WithMessage($"CNPJ inválido.");

            RuleFor(c => c.RazaoSocial)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} RazaoSocial.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Razao Social'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Razao Social é 100.");
        }
    }
}
