using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _service;

        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            ICollection<Endereco> obj = _service.SelectAll();
            if (obj == null || obj.Count == 0)
                return NotFound();

            return Ok(obj);
        }

        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            Endereco obj = _service.Select(id);
            if (obj == null)
                return NotFound("Objeto não encontrado.");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Inserir(Endereco obj)
        {
            _service.Insert(obj);
            return Ok(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(Endereco obj)
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