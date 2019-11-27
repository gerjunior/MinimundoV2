using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class UsuarioTests
    {
        #region Geral
        [TestMethod]
        public void ObjetoValido()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(true, result.IsValid);
        }

        #endregion

        #region UsuarioID

        [TestMethod]
        public void UsuarioIDNulo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        #endregion

        #region Email

        [TestMethod]
        public void EmailNulo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = null,
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        public void EmailVazio()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailEspacoBranco()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = " ",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailInvalido1 ()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmailcom",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailInvalido2()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojunihotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailInvalido3()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailInvalido4()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "Isto é uma string, não um email",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void EmailInvalidoLimiteCaracteres()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "gegeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojunigeraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }
        #endregion

        #region Senha

        [TestMethod]
        public void SenhaInvalidaMenos8Caracteres()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@567",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaInvalidaLimiteCaracteres()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@5678Aa1@567@567",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaNula()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = null,
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaVazia()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaEspacoBranco()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = " ",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaInvalidaSemCaracterMaiusculo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaInvalidaSemCaracterMinusculo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "AA1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaInvalidaSemCaracterEspecial()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa135678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SenhaInvalidaSemNumero()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aaa@abcd",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        #endregion

        #region Nome
        [TestMethod]
        public void NomeNulo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = null,
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void NomeVazio()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void NomeEspacoBranco()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = " ",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void NomeLimiteCaracteres()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "GeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldoGeraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        #endregion Nome

        #region CPF

        [TestMethod]
        public void CPFNulo()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = null,
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void CPFVazio()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void CPFEspacoBranco()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = " ",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void CPFInvalido1()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "0968838065",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void CPFInvalido2()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "096883806523",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void CPFInvalido3()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688580652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        #endregion

        #region Sexo

        [TestMethod]
        public void SexoEspacoBranco()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = ' '
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SexoInvalido()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'A'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(false, result.IsValid);
        }

        [TestMethod]
        public void SexoM()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'M'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(true, result.IsValid);
        }

        [TestMethod]
        public void SexoF()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'F'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(true, result.IsValid);
        }

        [TestMethod]
        public void SexoO()
        {
            UsuarioValidator validator = new UsuarioValidator();

            Usuario usuario = new Usuario
            {
                UsuarioID = 1,
                Email = "geraldojuni@hotmail.com",
                Senha = "Aa1@5678",
                Nome = "Geraldo",
                CPF = "09688380652",
                Sexo = 'O'
            };

            var result = validator.Validate(usuario);

            Assert.AreEqual(true, result.IsValid);
        }

        #endregion

    }
}
