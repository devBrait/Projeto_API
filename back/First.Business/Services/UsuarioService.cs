using First.Core.Interfaces;
using First.Core.Models;
using First.Data.Context;

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

     public async Task<Usuario> UpdateUsuarioAsync(Usuario usuario)
    {

        var usuarioAlterado = new Usuario
        { 
            id = usuario.id,
            nome = usuario.nome,
            email = usuario.email,
            telefone = usuario.telefone,
            senha = usuario.senha
        };

        AppDbContext.Update(usuarioAlterado);
        await AppDbContext.SaveChangesAsync();
        return usuarioAlterado;
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