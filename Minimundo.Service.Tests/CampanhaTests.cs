using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;
using System;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class CampanhaTests
    {
        #region Geral

        [TestMethod]
        public void ObjetoNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha();

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion

        #region CampanhaID
        [TestMethod]
        public void CampanhaIDNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion CampanhaID

        #region AvaliadorID
        [TestMethod]
        public void AvaliadorIDNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion AvaliadorID

        #region EmpresaID
        public void EmpresaIDNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                AvaliadorID = 1,
                CampanhaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion EmpresaID

        #region Responsavel

        [TestMethod]
        public void ResponsavelNull()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = null,
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void ResponsavelVazio()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void Responsavel100Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void Responsavel101Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        #endregion

        #region Nome
        [TestMethod]
        public void NomeNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = null,
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void NomeVazio()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void Nome100Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void Nome101Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion Nome

        #region Descricao
        [TestMethod]
        public void DescicaoNulo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = null,
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void DescricaoVazio()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void Descricao100Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void Descricao101Caracteres()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                InicioPeriodo = Convert.ToDateTime("26/11/2019"),
                FimPeriodo = Convert.ToDateTime("27/11/2019"),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion Descricao

        #region InicioPeriodo e FimPeriodo

        [TestMethod]
        public void FimPeriodoMenorQueInicioPeriodo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = DateTime.Now,
                FimPeriodo = DateTime.Now.AddDays(-1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void FimPeriodoIgualInicioPeriodo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data,
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void FimPeriodoMaiorQueInicioPeriodo()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }
        #endregion InicioPeriodo e FimPeriodo

        #region ValorPremio

        [TestMethod]
        public void ValorPremioMenorQueZero()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = -1,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void ValorPremioIgualZero()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 0,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void ValorPremioMaiorQueZero()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1000,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion ValorPremio

        #region Status

        [TestMethod]
        public void StatusA()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 10000,
                Status = 'A'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }


        [TestMethod]
        public void StatusF()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1000,
                Status = 'F'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(true, resultado.IsValid);
        }

        [TestMethod]
        public void StatusInvalido()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1000,
                Status = 'B'
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }

        [TestMethod]
        public void StatusNull()
        {
            CampanhaValidator validator = new CampanhaValidator();

            DateTime data = DateTime.Now;
            Campanha campanha = new Campanha
            {
                CampanhaID = 1,
                AvaliadorID = 1,
                EmpresaID = 1,
                Descricao = "Teste",
                InicioPeriodo = data,
                FimPeriodo = data.AddDays(1),
                Nome = "Teste",
                Responsavel = "Teste",
                ValorPremio = 1000
            };

            var resultado = validator.Validate(campanha);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion
    }
}
