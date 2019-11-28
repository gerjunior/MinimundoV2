using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Controllers;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustoSugestaoController : Controller
    {
        private readonly ICustoSugestaoService _service;
        private readonly IBaseController<CustoSugestao> _controllerValidator;

        public CustoSugestaoController(ICustoSugestaoService service, IBaseController<CustoSugestao> controllerValidator)
        {
            _service = service;
            _controllerValidator = controllerValidator;
        }

        #region CRUD

        [Route("ListarTodos")]
        public Resposta ListarTodos()
        {
            IEnumerable<CustoSugestao> obj = _service.SelectAll();
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Resposta Mostrar(int id)
        {
            CustoSugestao obj = _service.Select(id);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPost]
        public Resposta Inserir(CustoSugestao obj)
        {
            _service.Insert(obj);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPut]
        public Resposta Atualizar(CustoSugestao obj)
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