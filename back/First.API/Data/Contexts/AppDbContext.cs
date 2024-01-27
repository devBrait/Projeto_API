using System;
using System.Net.Sockets;
using First.API.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace First.API.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, true)
        .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}