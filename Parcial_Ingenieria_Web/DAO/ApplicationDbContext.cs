using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Parcial_Ingenieria_Web.DAO
{
        public class ApplicationDbContext : IdentityDbContext<IdentityUser>
        {

            //Constructor que recibe las opciones de conexión a la bd para tener contexto de esta
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        }
    }

