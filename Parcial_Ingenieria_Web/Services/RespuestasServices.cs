using Parcial_Ingenieria_Web.DAO;
using Parcial_Ingenieria_Web.Models;

namespace Parcial_Ingenieria_Web.Services
{
    public class RespuestasServices
    {
        private readonly ApplicationDbContext _context;

        public RespuestasServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Respuestas> getById(Guid id)
            
        {
            if (id == null) return null;
            return await _context.Respuestas.Where(e => e.Pregunta_id == id);
        }
        public async Task<bool> CambiarEstado(Guid id)
        {
            // Verificamos si existe o no el registro
            var existe = await getById(id);
            if (existe == null) return false;

            existe.Estado = "resuelta";

            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<Respuestas> Create(Respuestas newRespuesta, Guid PreguntaId)
        {
            //Agregamos el registro a la lista
            if (_context.Respuestas.CambiarEstado(PreguntaId)) { 
            _context.Respuestas.Add(newRespuesta);
            await _context.SaveChangesAsync();
            return newRespuesta;
        } return null;
        }
    }
}
