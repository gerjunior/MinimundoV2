using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Authorize("Bearer")]
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            ICollection<Usuario> obj = _service.SelectAll();
            if (obj == null || obj.Count == 0)
                return NotFound();

            return Ok(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            Usuario obj = _service.Select(id);
            if (obj == null)
                return NotFound("Objeto não encontrado.");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Inserir(Usuario obj)
        {
            _service.Insert(obj);
            return Ok(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(Usuario obj)
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
                return NotFound("Objeto não encontrado.");

            return Ok("Objeto removido com sucesso.");
        }

        #endregion CRUD
    }
}