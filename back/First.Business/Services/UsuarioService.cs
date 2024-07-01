using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Core.Interfaces;
using First.Core.Models;
using First.Data.Context;
using First.Data.Repositories;

namespace First.Business.Services
{
    public class UsuarioService 
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly AppDbContext AppDbContext;

        public UsuarioService(IUsuarioRepository usuarioRepository, AppDbContext appDbContext)
        {
            _usuarioRepository = usuarioRepository;
            AppDbContext = appDbContext;
        }

        public async Task<List<Usuario>> getUsuarioAsync()
    {   
            return await _usuarioRepository.GetUsuarioAsync();
    }

    public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
    {
        return await _usuarioRepository.CreateUsuarioAsync(usuario);
    }

    public async Task<bool> DeleteUsuarioAsync(int cod_usuario)
    {
        var usuario = await AppDbContext.Usuarios.FindAsync(cod_usuario);

        if (usuario == null)
        {
            return false;
        }

        AppDbContext.Usuarios.Remove(usuario);
        await AppDbContext.SaveChangesAsync();
        return true;
    }
    }
}