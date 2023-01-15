using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRUEBA02.Database;
using PRUEBA02.repositorio;

namespace PRUEBA02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
      PersonaRepositorio _repo= new PersonaRepositorio();
        [HttpGet]
        public IActionResult getAll()
        {
            List<Persona> lst = _repo.getAll();
            return Ok(lst);
        }
        [HttpGet("complete")]
        public IActionResult getAllcomplete()
        {
            List<Persona> lst = _repo.getAllComplete();
            return Ok(lst);
        }
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            Persona registro = _repo.getById(id);
            return Ok(registro);
        }
        [HttpPost]
        public IActionResult create([FromBody] Persona request)
        {
            Persona registro = _repo.create(request);
            return Ok(registro);
        }
        [HttpPut]
        public IActionResult update([FromBody] Persona request)
        {
            Persona registro = _repo.update(request);
            return Ok(registro);
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int registro = _repo.delete(id);
            return Ok(registro);
        }

    }
}
