using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustoSugestaoController : Controller
    {
        private readonly ICustoSugestaoService _service;

        public CustoSugestaoController(ICustoSugestaoService service)
        {
            _service = service;
        }

        #region CRUD

        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            IEnumerable<CustoSugestao> obj = _service.SelectAll();
            return Json(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            CustoSugestao obj = _service.Select(id);
            return Json(obj);
        }

        [HttpPost]
        public IActionResult Inserir(CustoSugestao obj)
        {
            _service.Insert(obj);
            return Json(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(CustoSugestao obj)
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