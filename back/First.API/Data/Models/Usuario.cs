using System;

namespace First.API.Data.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public int telefone { get; set; }
        public int senha { get; set; }
    }
}