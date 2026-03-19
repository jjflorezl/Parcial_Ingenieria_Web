using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial_Ingenieria_Web.Models;
using System.Diagnostics;

namespace Parcial_Ingenieria_Web.DAO
{
        public class ApplicationDbContext : IdentityDbContext<IdentityUser>
        {

            //Constructor que recibe las opciones de conexión a la bd para tener contexto de esta
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }
    }
    }

