
using System.Collections.Generic;
using System.Threading.Tasks;
using First.Core.Models;

namespace First.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetUsuarioAsync();

        Task<Usuario> CreateUsuarioAsync(Usuario usuario);
    }
}
