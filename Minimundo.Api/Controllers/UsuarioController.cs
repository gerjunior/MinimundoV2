using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUsuarioService _service;
        //private readonly IConfiguration _configuration;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
            //_userManager = userManager;
            //_signInManager = signInManager;
            //_configuration = configuration;
        }

        //[HttpPost("Criar")]
        //public async Task<ActionResult<UserToken>> CreateUser([FromBody] Usuario model)
        //{
        //    var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
        //    var result = await _userManager.CreateAsync(user, model.Senha);
        //    if (result.Succeeded)
        //    {
        //        return BuildToken(model);
        //    }
        //    else
        //    {
        //        return BadRequest("Usuário ou senha inválidos");
        //    }
        //}

        //[HttpPost("Login")]
        //public async Task<ActionResult<UserToken>> Login([FromBody] Usuario userInfo)
        //{
        //    var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Senha,
        //         isPersistent: false, lockoutOnFailure: false);

        //    if (result.Succeeded)
        //    {
        //        return BuildToken(userInfo);
        //    }
        //    else
        //    {
        //        ModelState.AddModelError(string.Empty, "login inválido.");
        //        return BadRequest(ModelState);
        //    }
        //}

        #region CRUD

        public IActionResult ListarTodos()
        {
            IEnumerable<Usuario> obj = _service.SelectAll();
            return Json(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            Usuario obj = _service.Select(id);
            return Json(obj);
        }

        [HttpPost]
        public IActionResult Inserir(Usuario obj)
        {
            _service.Insert(obj);
            return Json(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(Usuario obj)
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

        //private UserToken BuildToken(Usuario userInfo)
        //{
        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
        //        new Claim("meuValor", "oque voce quiser"),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    };
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    // tempo de expiração do token: 1 hora
        //    var expiration = DateTime.UtcNow.AddHours(1);
        //    JwtSecurityToken token = new JwtSecurityToken(
        //       issuer: null,
        //       audience: null,
        //       claims: claims,
        //       expires: expiration,
        //       signingCredentials: creds);
        //    return new UserToken()
        //    {
        //        Token = new JwtSecurityTokenHandler().WriteToken(token),
        //        Expiration = expiration
        //    };
        //}
    }
}