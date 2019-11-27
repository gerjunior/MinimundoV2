using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class CustoSugestaoTests
    {
        #region Geral

        [TestMethod]
        public void ObjetoValido()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void ObjetoNulo()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao();

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Geral

        #region CustoSugestaoID

        [TestMethod]
        public void CustoSugestaoIDNulo()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion CustoSugestaoID

        #region SugestaoID

        [TestMethod]
        public void SugestaoIDNulo()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion SugestaoID

        #region DescricaoCusto

        [TestMethod]
        public void DescricaoCustoNulo()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = null,
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void DescricaoCustoVazio()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void DescricaoCustoEspacoEmBranco()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = " ",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void DescricaoCustoValido()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion DescricaoCusto

        #region Valor

        [TestMethod]
        public void ValorMenorQueZero()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = -1
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void ValorMaiorQueZero()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 1000
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void ValorIgualAZero()
        {
            CustoSugestaoValidator validator = new CustoSugestaoValidator();
            CustoSugestao custoSugestao = new CustoSugestao()
            {
                CustoSugestaoID = 1,
                SugestaoID = 1,
                DescricaoCusto = "Teste",
                Valor = 0
            };

            var resultado = validator.Validate(custoSugestao);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion
    }
}
