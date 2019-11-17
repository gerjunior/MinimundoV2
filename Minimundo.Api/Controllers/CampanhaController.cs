using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CampanhaController : Controller
    {
        private readonly ICampanhaService _service;

        public CampanhaController(ICampanhaService service)
        {
            _service = service;
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            IEnumerable<Campanha> obj = _service.SelectAll();

            return Json(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            Campanha obj = _service.Select(id);
            return Json(obj);
        }

        [HttpPost]
        public IActionResult Inserir(Campanha obj)
        {
            _service.Insert(obj);
            return Json(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(Campanha obj)
        {
            _service.Update(obj);
            return Json(obj);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Deletar(int id)
        {
            var obj = _service.Delete(id);
            return Json(obj);
        }

        #endregion CRUD
    }
}