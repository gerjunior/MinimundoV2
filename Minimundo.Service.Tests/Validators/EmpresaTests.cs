using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class EmpresaTests
    {
        #region Geral

        [TestMethod]
        public void ObjetoValido()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion

        #region EmpresaID
        [TestMethod]
        public void EmpresaIDNulo()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion EmpresaID

        #region NomeFantasia

        [TestMethod]
        public void NomeFantasiaNulo()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = null,
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NomeFantasiaVazio()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "",
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NomeFantasiaEspacoEmBranco()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = " ",
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NomeFantasiaLimiteCaracteres()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                RazaoSocial = "Teste",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion NomeFantasia

        #region RazaoSocial

        [TestMethod]
        public void RazaoSocialNulo()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = null,
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RazaoSocialVazio()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RazaoSocialEspacoEmBranco()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = " ",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RazaoSocialLimiteCaracteres()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                CNPJ = "91217118000121"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion RazaoSocial

        #region CNPJ

        [TestMethod]
        public void CNPJNulo()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = null
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CNPJVazio()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = ""
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CNPJEspacoEmBranco()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = " "
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CNPJInvalido()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = "12348"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CNPJValidoComPontuacao()
        {
            EmpresaValidator validator = new EmpresaValidator();
            Empresa empresa = new Empresa()
            {
                EmpresaID = 1,
                NomeFantasia = "Teste",
                RazaoSocial = "Teste",
                CNPJ = "81.232.217/0001-29"
            };

            var resultado = validator.Validate(empresa);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion

    }
}
