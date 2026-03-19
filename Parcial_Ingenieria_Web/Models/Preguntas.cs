using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_Ingenieria_Web.Models
{
    public class Preguntas
    {

            [Key]
            public Guid Cliente_Id { get; set; } = Guid.NewGuid();
            [Required]
            public string Enunciado { get; set; }
            public string Catergoria { get; set; }
        public EstadoPregunta Estado { get; set; } = EstadoPregunta.sin_resolver;


         
        }
    }


