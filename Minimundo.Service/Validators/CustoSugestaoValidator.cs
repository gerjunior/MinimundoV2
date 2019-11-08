﻿using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class CustoSugestaoValidator : AbstractValidator<CustoSugestao>
    {
        public CustoSugestaoValidator()
        {
            RuleFor(c => c.CustoSugestaoID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} CustoSugestaoID.");

            RuleFor(c => c.SugestaoID)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} SugestaoID.");

            RuleFor(c => c.DescricaoCusto)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} DescricaoCusto.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Descricao de Custo'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} DescricaoCusto é 100.");

            RuleFor(c => c.Valor)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Valor.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Valor de Custo'.")
                .GreaterThanOrEqualTo(0).WithMessage("O valor de custo não pode ser inferior a 0.");
        }
    }
}