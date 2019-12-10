using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class EnderecoTests
    {
        #region Geral

        [TestMethod]
        public void ObjetoValido()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion Geral

        #region EnderecoID

        [TestMethod]
        public void EnderecoIDNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion EnderecoID

        #region UsuarioID

        [TestMethod]
        public void UsuarioIDNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion UsuarioID

        #region CEP

        [TestMethod]
        public void CEPNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = null,
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CEPVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CEPEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = " ",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CEPInvalido()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "123",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CEPValidoComPontuacao()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void CEPValidoSemPontuacao()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion CEP

        #region Estado

        [TestMethod]
        public void EstadoNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = null,
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void EstadoVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void EstadoEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = " ",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void EstadoInvalido()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "M",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void EstadoLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "Minas Gerais",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Estado

        #region Cidade

        [TestMethod]
        public void CidadeNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = null,
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CidadeVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CidadeEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = " ",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void CidadeLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Cidade

        #region Bairro

        [TestMethod]
        public void BairroNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = null,
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void BairroVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void BairroEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = " ",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void BairroLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Rua = "Francisco dos Santos",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Bairro

        #region Rua

        [TestMethod]
        public void RuaNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = null,
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RuaVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RuaEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = " ",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void RuaLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Numero = "326",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Rua

        #region Numero

        [TestMethod]
        public void NumeroNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = null,
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NumeroVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = "",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NumeroEspacoEmBranco()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970-000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Gato",
                Rua = "Francisco dos Santos",
                Numero = " ",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NumeroLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Complemento = "Uma casa muito engraçada, sem teto sem nada."
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Numero

        #region Complemento

        [TestMethod]
        public void ComplementoNulo()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = "326",
                Complemento = null
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void ComplementoVazio()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = "326",
                Complemento = ""
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void ComplementoLimiteCaracteres()
        {
            EnderecoValidator validator = new EnderecoValidator();

            Endereco endereco = new Endereco()
            {
                EnderecoID = 1,
                UsuarioID = 1,
                CEP = "38970000",
                Estado = "MG",
                Cidade = "Campos Claros",
                Bairro = "Dona Aranha",
                Rua = "Rua dos Eita",
                Numero = "326",
                Complemento = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
            };

            var resultado = validator.Validate(endereco);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion Complemento
    }
}