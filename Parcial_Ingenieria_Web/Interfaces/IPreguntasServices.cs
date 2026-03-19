using Parcial_Ingenieria_Web.Models;

namespace Parcial_Ingenieria_Web.Interfaces
{
    public interface IPreguntasServices
    {
        Task<Preguntas> Create(Preguntas pregunta);
        Task<Preguntas?> GetByEstado(EstadoPregunta estado);
    }
}
