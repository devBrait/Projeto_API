using First.Core.Interfaces;
using First.Core.Models;
using First.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace First.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
    private readonly AppDbContext _AppdbContext;

    public UsuarioRepository(AppDbContext dbContext)
    {
        _AppdbContext = dbContext;
    }

   public async Task<List<Usuario>> GetUsuarioAsync()
    {
            var usuarios = await _AppdbContext.Usuarios.ToListAsync();
            return usuarios;
    }

    public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
    {
       var usuarioCriado = _AppdbContext.Usuarios.Add(usuario);

        await _AppdbContext.SaveChangesAsync();

        return usuarioCriado.Entity;
    }
    }
}