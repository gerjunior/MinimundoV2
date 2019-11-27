using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class SugestaoAvaliacaoTests
    {
        #region Geral
        [TestMethod]
        public void ObjetoValido()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }
        #endregion

        #region SugestaoAvaliacaoID

        [TestMethod]
        public void SugestaoAvaliacaoIDNulo()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoID = 1,
                Nota = 10,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region SugestaoID

        [TestMethod]
        public void SugestaoIDNulo()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                Nota = 10,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region Nota

        [TestMethod]
        public void NotaNula()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void NotaMenorQueZero()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = -1,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void NotaIgualADez()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void NotaMaiorQueDez()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 11,
                Informacao = "Não tem"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion

        #region Informacao

        [TestMethod]
        public void InformacaoValida()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = "Informação informada"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void InformacaoNula()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = null
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void InformacaoVazia()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = ""
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void InformacaoEspacoEmBranco()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = " "
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void InformacaoMaiorQueLimiteDeCaracteres()
        {
            SugestaoAvaliacaoValidator validator = new SugestaoAvaliacaoValidator();

            SugestaoAvaliacao sugestaoAvaliacao = new SugestaoAvaliacao
            {
                SugestaoAvaliacaoID = 1,
                SugestaoID = 1,
                Nota = 10,
                Informacao = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
            };

            var response = validator.Validate(sugestaoAvaliacao);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion

    }
}
