using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_Ingenieria_Web.Models
{
    public class Respuestas
    {
            [Key]
            public Guid Respuesta_Id { get; set; } = Guid.NewGuid();

            public string Contenido { get; set; }

            public DateTime Fecha_creacion { get; set; } = DateTime.Now;

            [Required]
            public Guid Pregunta_id { get; set; }

            [ForeignKey("Pregunta_id")]
            public Preguntas Pregunta { get; set; }

        
    }
}

