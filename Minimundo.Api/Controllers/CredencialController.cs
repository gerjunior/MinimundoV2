using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities.Authentication;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Api.Controllers
{
    public class CredencialController : Controller
    {
        private readonly ICredencialService _service;

        public CredencialController(ICredencialService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(credencial credencial)
        {
            var credencialRetorno = _service.Select(credencial.userApi);

            if (credencialRetorno == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}