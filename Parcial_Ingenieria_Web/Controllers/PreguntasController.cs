using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parcial_Ingenieria_Web.Interfaces;
using Parcial_Ingenieria_Web.Models;
using System.Net;

namespace Parcial_Ingenieria_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : Controller
    {
        private readonly IPreguntasServices _preguntasService;

        public PreguntasController(IPreguntasServices preguntaService)
        {
            _preguntasService = preguntaService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("{estado}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByEstado(String estado)
        {
            List<Preguntas> Pregunta = await _preguntasService.GetByEstado(estado);
            //Se refactoriza condicion por una operación ternaria o si corto
            return Pregunta != null ? Ok(Pregunta) : NotFound();
          
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Preguntas newPregunta)
        {

            var createdPregunta= await _preguntasService.Create(newPregunta);
            return CreatedAtAction(nameof(GetByEstado), new { id = createdPregunta.Pregunta_Id }, createdPregunta);

        }



    }
}
