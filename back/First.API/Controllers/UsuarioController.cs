using First.Business.Services;
using First.Core.Models;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<IActionResult> getUsuariosAsync()
        {   
            var usuarios = await _usuarioService.getUsuarioAsync();

            if (usuarios == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                success = true,
                data = usuarios
            });
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuarioAsync([FromBody]Usuario novoUsuario)
        {
            try
            {
                var usuarioCriado = await _usuarioService.CreateUsuarioAsync(novoUsuario);
                return Ok(usuarioCriado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuarioAsync([FromBody]Usuario usuario)
        {
            try
            {
                var usuarioAlterado = await _usuarioService.UpdateUsuarioAsync(usuario);
                return Ok(usuarioAlterado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{cod_usuario}")]
        public async Task<IActionResult> DeleteUsuarioAsync(int cod_usuario)
        {
            try
            {
                await _usuarioService.DeleteUsuarioAsync(cod_usuario);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}