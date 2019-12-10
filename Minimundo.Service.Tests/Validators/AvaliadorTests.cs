using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class AvaliadorTests
    {
        #region Geral

        [TestMethod]
        public void ObjetoValido()
        {
            Avaliador avaliador = new Avaliador();
            AvaliadorValidator validator = new AvaliadorValidator();
            avaliador.AvaliadorID = 1;
            avaliador.UsuarioID = 1;

            var resultado = validator.Validate(avaliador);
            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion Geral

        #region Null checks

        [TestMethod]
        public void AvaliadorIDNull()
        {
            Avaliador avaliador = new Avaliador();
            AvaliadorValidator validator = new AvaliadorValidator();
            avaliador.UsuarioID = 1;

            var resultado = validator.Validate(avaliador);
            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void UsuarioIDNull()
        {
            Avaliador avaliador = new Avaliador();
            AvaliadorValidator validator = new AvaliadorValidator();
            avaliador.AvaliadorID = 1;

            var resultado = validator.Validate(avaliador);
            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void AmbosNull()
        {
            Avaliador avaliador = new Avaliador();
            AvaliadorValidator validator = new AvaliadorValidator();

            var resultado = validator.Validate(avaliador);
            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Null checks
    }
}