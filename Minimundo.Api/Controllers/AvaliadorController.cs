using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Controllers;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvaliadorController : Controller
    {
        private readonly IAvaliadorService _service;
        private readonly IBaseController<Avaliador> _controllerValidator;

        public AvaliadorController(IAvaliadorService service, IBaseController<Avaliador> controllerValidator)
        {
            _service = service;
            _controllerValidator = controllerValidator;
        }

        #region CRUD

        public Resposta ListarTodos()
        {
            IEnumerable<Avaliador> obj = _service.SelectAll();
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Resposta Mostrar(int id)
        {
            Avaliador obj = _service.Select(id);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPost]
        public Resposta Inserir(Avaliador obj)
        {
            _service.Insert(obj);
            var validacao = _controllerValidator.Verificar(obj);
            return validacao;
        }

        [HttpPut]
        public Resposta Atualizar(Avaliador obj)
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