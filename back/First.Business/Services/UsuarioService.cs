using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Core.Interfaces;
using First.Core.Models;
using First.Data.Repositories;

namespace First.Business.Services
{
    public class UsuarioService 
    {
        private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

      public async Task<List<Usuario>> getUsuarioAsync()
    {   
            return await _usuarioRepository.GetUsuarioAsync();
    }

    public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
    {
        return await _usuarioRepository.CreateUsuarioAsync(usuario);
    }
    }
}