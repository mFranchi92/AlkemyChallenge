using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alkemy2.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Characters> Characters { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Users> Users { get; set; }
    }

    public class Characters
    {
        public int ID { get; set; }
        public string Imagen { get; set; }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Peso { get; set; }
        public string Historia { get; set; }

        public int MovieId { get; set; }

        public ICollection<Movies> Movies { get; set; }
     
    }

    public class Movies
    {
        public int ID { get; set; }

        public string Imagen { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaCreacion { get; set; }
        public int Calificacion { get; set; }

        public int PersonajeId { get; set; } 
    }

    public class Genre
    {
        public int ID { get; set; }

        public string Imagen { get; set; }

        public int MovieId { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }

    public class Users
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int StatusId { get; set; }

        public string Token { get; set; }
    }

}