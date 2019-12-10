﻿using Microsoft.AspNetCore.Mvc;
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
            ICollection<Campanha> obj = _service.SelectAll();

            if (obj == null || obj.Count == 0)
                return NotFound();

            return Ok(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            Campanha obj = _service.Select(id);

            if (obj == null)
                return NotFound("Objeto não encontrado.");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Inserir(Campanha obj)
        {
            if (obj == null)
                return BadRequest(Json("Objeto inválido."));

            _service.Insert(obj);

            return Ok(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(Campanha obj)
        {
            _service.Update(obj);

            return Ok(obj);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Deletar(int id)
        {
            var obj = _service.Delete(id);

            if (obj == null)
                return NotFound(Json("Objeto não encontrado."));

            return Ok("Objeto removido com sucesso.");
        }

        #endregion CRUD
    }
}