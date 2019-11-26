using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class TelefoneTests
    {
        #region Geral
        [TestMethod]
        public void ObjetoValido()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'C',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(true, response.IsValid);
        }
        #endregion

        #region TelefoneID
        [TestMethod]
        public void TelefoneIDNulo()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                UsuarioID = 1,
                Tipo = 'C',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion

        #region UsuarioID
        [TestMethod]
        public void UsuarioIDNulo()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                Tipo = 'C',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion

        #region Tipo
        [TestMethod]
        public void TipoVazio()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = ' ',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void TipoR()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'R',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void TipoC()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'C',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void TipoP()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(true, response.IsValid);
        }

        [TestMethod]
        public void TipoInvalido()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = '3',
                DDD = "37",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion

        #region DDI

        [TestMethod]
        public void DDINulo()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = null,
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DDIVazio()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DDILimiteCaracteres()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "123456",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region DDD

        [TestMethod]
        public void DDDNulo()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = null,
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DDDVazio()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void DDDLimiteCaracteres()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "123456",
                DDI = "55",
                Numero = "991785049"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        #endregion

        #region Numero
        [TestMethod]
        public void NumeroNulo()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "55",
                Numero = null
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void NumeroVazio()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "55",
                Numero = ""
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }

        [TestMethod]
        public void NumeroLimiteCaracteres()
        {
            TelefoneValidator validator = new TelefoneValidator();

            Telefone telefone = new Telefone
            {
                TelefoneID = 1,
                UsuarioID = 1,
                Tipo = 'P',
                DDD = "37",
                DDI = "55",
                Numero = "99178504910"
            };

            var response = validator.Validate(telefone);

            Assert.AreEqual(false, response.IsValid);
        }
        #endregion
    }
}
