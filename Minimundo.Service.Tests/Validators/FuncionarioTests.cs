using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimundo.Domain.Entities;
using Minimundo.Service.Validators;

namespace Minimundo.Service.Tests
{
    [TestClass]
    public class FuncionarioTests
    {

        #region Geral
        [TestMethod]
        public void ObjetoValido()
        {
            FuncionarioValidator validator = new FuncionarioValidator();

            Funcionario funcionario = new Funcionario
            {
                FuncionarioID = 1,
                UsuarioID = 1,
                EmpresaID = 1
            };

            var resultado = validator.Validate(funcionario);

            Assert.AreEqual(true, resultado.IsValid);
        }

        #endregion Geral

        #region FuncionarioID

        [TestMethod]
        public void FuncionarioIDNulo()
        {
            FuncionarioValidator validator = new FuncionarioValidator();

            Funcionario funcionario = new Funcionario
            {
                UsuarioID = 1,
                EmpresaID = 1
            };

            var resultado = validator.Validate(funcionario);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion

        #region UsuarioID
        [TestMethod]
        public void UsuarioIDNulo()
        {
            FuncionarioValidator validator = new FuncionarioValidator();

            Funcionario funcionario = new Funcionario
            {
                FuncionarioID = 1,
                EmpresaID = 1
            };

            var resultado = validator.Validate(funcionario);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion

        #region EmpresaID
        [TestMethod]
        public void EmpresaIDNulo()
        {
            FuncionarioValidator validator = new FuncionarioValidator();

            Funcionario funcionario = new Funcionario
            {
                UsuarioID = 1,
                FuncionarioID = 1,
            };

            var resultado = validator.Validate(funcionario);

            Assert.AreEqual(false, resultado.IsValid);
        }
        #endregion
    }
}
