using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities.Authentication;
using Minimundo.Domain.Interfaces.Controllers;
using Minimundo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimundo.Api.Controllers
{
    public class CredencialController : Controller
    {
        private readonly ICredencialService _service;
        private readonly IBaseController<credencial> _controllerValidator;


        public CredencialController(ICredencialService service, IBaseController<credencial> controllerValidator)
        {
            _service = service;
            _controllerValidator = controllerValidator;
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
