using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRUEBA02.Database;
using PRUEBA02.repositorio;

namespace PRUEBA02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        CargoRepositorio re= new CargoRepositorio();
        [HttpGet]
        public IActionResult getAll()
        {
            List<Cargo> lst = re.getAll();
            return Ok(lst);
        }
      
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            Cargo registro = re.getById(id);
            return Ok(registro);
        }
        [HttpPost]
        public IActionResult create([FromBody] Cargo request)
        {
            Cargo registro = re.create(request);
            return Ok(registro);
        }
        [HttpPut]
        public IActionResult update([FromBody] Cargo request)
        {
            Cargo registro = re.update(request);
            return Ok(registro);
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int registro = re.delete(id);
            return Ok(registro);
        }
    }
}
