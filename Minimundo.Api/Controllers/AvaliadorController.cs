using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Service.Service;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    public class AvaliadorController : Controller
    {
        private readonly AvaliadorService _service;

        public AvaliadorController()
        {
            _service = new AvaliadorService();
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            IEnumerable<Avaliador> obj = _service.SelectAll();
            return View(obj);
        }

        public IActionResult Mostrar(int id)
        {
            Avaliador obj = _service.Select(id);
            return View(obj);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(Avaliador obj)
        {
            _service.Insert(obj);
            return RedirectToAction("ListarTodos");
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Atualizar(Avaliador obj)
        {
            _service.Update(obj);
            return RedirectToAction("ListarTodos");
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            _service.Delete(id);
            return RedirectToAction("ListarTodos");
        }

        #endregion CRUD
    }
}