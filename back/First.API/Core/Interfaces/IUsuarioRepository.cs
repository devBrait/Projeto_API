using First.API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace First.API.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetUsuarioAsync();
    }
}
