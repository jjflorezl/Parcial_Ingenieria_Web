using Parcial_Ingenieria_Web.Models;

namespace Parcial_Ingenieria_Web.Interfaces
{
    public interface IRespuestaService
    {
        Task<Respuestas> Create(Respuestas respuesta, Guid PreguntaId);
        Task<bool> CambiarEstado(Guid PreguntaId);
        Task<Preguntas> getById(Guid id);

    }
}
