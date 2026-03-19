using Microsoft.AspNetCore.Mvc;
using Parcial_Ingenieria_Web.Interfaces;
using Parcial_Ingenieria_Web.Models;

namespace Parcial_Ingenieria_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestasController : Controller
    {
        private readonly IRespuestaService _respuestasService;

        public RespuestasController(IRespuestaService respuestaService)
        {
            _respuestasService = respuestaService;
        }
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Respuestas newRespuesta, Guid PreguntaId)
        {
           
            var createdRespuesta= await _respuestasService.Create(newRespuesta);
            return Ok(createdRespuesta);

        }
    }
}
