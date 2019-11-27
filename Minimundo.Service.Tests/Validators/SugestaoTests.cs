using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class SugestaoTests
    {
        #region Geral
        [TestMethod]
        public void ObjetoValido()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                SugestaoID = 1,
                CampanhaID = 1,
                FuncionarioID = 1,
                Descricao = "Descrição Válida"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(true, response.IsValid);
        }
        #endregion Geral

        #region SugestaoID

        [TestMethod]
        public void SugestaoIDNulo()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                Descricao = "Descrição Válida"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region CampanhaID

        [TestMethod]
        public void CampanhaIDNulo()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                SugestaoID = 1,
                FuncionarioID = 1,
                Descricao = "Descrição Válida"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region FuncionarioID

        [TestMethod]
        public void FuncionarioIDNulo()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                SugestaoID = 1,
                Descricao = "Descrição Válida"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region Descricao
        [TestMethod]
        public void DescricaoMenorQueDezCaracteres()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = "Descrição"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DescricaoVazia()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = ""
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DescricaoNula()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = null
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DescricaoEspacoBranco()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                SugestaoID = 1,
                CampanhaID = 1,
                FuncionarioID = 1,
                Descricao = " "
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DescricaoEspacoBranco10Caracteres()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                SugestaoID = 1,
                CampanhaID = 1,
                FuncionarioID = 1,
                Descricao = "           "
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DescricaoDezCaracteres()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = "0123456789"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void Descricao500Caracteres()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAA"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void DescricaoMaiorQue500Caracteres()
        {
            SugestaoValidator validator = new SugestaoValidator();

            Sugestao sugestao = new Sugestao
            {
                CampanhaID = 1,
                FuncionarioID = 1,
                SugestaoID = 1,
                Descricao = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
            };

            var response = validator.Validate(sugestao);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion
    }
}
