using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Service.Service;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    public class SugestaoAvaliacaoController : Controller
    {
        private readonly SugestaoAvaliacaoService _service;

        public SugestaoAvaliacaoController()
        {
            _service = new SugestaoAvaliacaoService();
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            IEnumerable<SugestaoAvaliacao> obj = _service.SelectAll();
            return View(obj);
        }

        public IActionResult Mostrar(int id)
        {
            SugestaoAvaliacao obj = _service.Select(id);
            return View(obj);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(SugestaoAvaliacao obj)
        {
            _service.Insert(obj);
            return RedirectToAction("ListarTodos");
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Atualizar(SugestaoAvaliacao obj)
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