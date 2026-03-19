using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial_Ingenieria_Web.DAO;
using Parcial_Ingenieria_Web.Interfaces;
using Parcial_Ingenieria_Web.Models;

namespace Parcial_Ingenieria_Web.Services
{
    public class PreguntasServices : IPreguntasServices
    {
        private readonly ApplicationDbContext _context;

        public PreguntasServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Preguntas?>> GetByEstado(String estado)
            
        {
            if (estado != "sin_resolver" || estado != "resuelta") return null;
                return await _context.Preguntas.Where(e => e.Estado == estado).ToListAsync();
        }
        public async Task<Preguntas> Create(Preguntas newPreguntas)
        {
            //Agregamos el registro a la lista
            _context.Preguntas.Add(newPreguntas);
            await _context.SaveChangesAsync();
            return newPreguntas;
        }

        
    }
}
