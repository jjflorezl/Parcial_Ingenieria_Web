using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_Ingenieria_Web.Models
{
    public class Preguntas
    {

            [Key]
            public Guid Pregunta_Id { get; set; } = Guid.NewGuid();
            [Required]
            public string Enunciado { get; set; }
            public string Catergoria { get; set; }
        public String Estado { get; set; } = "sin_resolver";


         
        }
    }


