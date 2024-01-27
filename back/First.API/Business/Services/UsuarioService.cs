using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Data.Models;
using First.API.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace First.API.Business.Services
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