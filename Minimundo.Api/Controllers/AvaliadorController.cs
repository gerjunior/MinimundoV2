using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Minimundo.Api.Controllers
{
    public class AvaliadorController : Controller
    {
        public IActionResult ListarTodos()
        {
            return View();
        }
    }
}