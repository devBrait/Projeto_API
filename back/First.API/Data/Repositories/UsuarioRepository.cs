using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Core.Interfaces;
using First.API.Data.Contexts;
using First.API.Data.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace First.API.Data.Repositories
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
    }
}