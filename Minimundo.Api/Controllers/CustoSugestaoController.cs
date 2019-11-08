using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Service.Service;

namespace Minimundo.Api.Controllers
{
    public class CustoSugestaoController : Controller
    {
        private CustoSugestaoService _service;
        public CustoSugestaoController()
        {
            _service = new CustoSugestaoService();
        }

        #region CRUD
        public IActionResult ListarTodos()
        {
            IEnumerable<CustoSugestao> obj = _service.SelectAll();
            return View(obj);
        }

        public IActionResult Mostrar(int id)
        {
            CustoSugestao obj = _service.Select(id);
            return View(obj);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(CustoSugestao obj)
        {
            _service.Insert(obj);
            return RedirectToAction("ListarTodos");
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Atualizar(CustoSugestao obj)
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

        #endregion
    }
}