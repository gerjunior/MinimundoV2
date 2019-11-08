using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;
using System.Text.RegularExpressions;

namespace Minimundo.Service.Validators
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(c => c.EnderecoID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} EnderecoID.");

            RuleFor(c => c.UsuarioID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} UsuarioID.");

            RuleFor(c => c.CEP)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} CEP.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'CEP'.")
                .Must(CEP).WithMessage($"CEP inválido.")
                .Length(8).WithMessage($"O CEP possui 8 caracteres somente.");

            RuleFor(c => c.Estado)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Estado.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Estado'.")
                .Length(2);

            RuleFor(c => c.Cidade)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Cidade.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Cidade'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Cidade é 100.");

            RuleFor(c => c.Bairro)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Bairro.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Bairro'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Bairro é 100.");

            RuleFor(c => c.Rua)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Rua.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Rua'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Rua é 100.");

            RuleFor(c => c.Numero)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Numero.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Numero'.")
                .MaximumLength(9).WithMessage($"{ValidatorConst.Maximo} Número é 9.");

            RuleFor(c => c.Complemento)
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Número é 9.");
        }

        public static bool CEP(string CEP)
        {
            Regex Rgx = new Regex(@"^\d{5}-\d{3}$");

            return Rgx.IsMatch(CEP);
        }
    }
}
