using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using First.API.Business.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace First.API.Controllers
{
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> getUsuariosAsync()
        {   
            var usuarios = await _usuarioService.getUsuarioAsync();

            if (usuarios == null)
            {
                return NotFound(); // ou outro código de status apropriado
            }

            return Ok(new
            {
                success = true,
                data = usuarios
            });
        }
    }
}