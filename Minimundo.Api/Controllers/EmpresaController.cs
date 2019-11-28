using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Controllers;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _service;
        private readonly IBaseController<Empresa> _controllerValidator;

        public EmpresaController(IEmpresaService service, IBaseController<Empresa> controllerValidator)
        {
            _service = service;
            _controllerValidator = controllerValidator;
        }

        #region CRUD

        public Resposta ListarTodos()
        {
            IEnumerable<Empresa> obj = _service.SelectAll();
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Resposta Mostrar(int id)
        {
            Empresa obj = _service.Select(id);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPost]
        public Resposta Inserir(Empresa obj)
        {
            _service.Insert(obj);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPut]
        public Resposta Atualizar(Empresa obj)
        {
            _service.Update(obj);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public Resposta Deletar(int id)
        {
            var obj = _service.Delete(id);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        #endregion CRUD
    }
}