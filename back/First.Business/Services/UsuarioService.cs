using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Core.Models;
using First.Data.Repositories;

namespace First.Business.Services
{
    public class UsuarioService 
    {
        private readonly UsuarioRepository _usuarioRepository;

    public UsuarioService(UsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

      public async Task<List<Usuario>> getUsuarioAsync()
    {   
            return await _usuarioRepository.GetUsuarioAsync();
    }
    }
}