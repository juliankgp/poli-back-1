using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App_Example_Resp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionesController : ControllerBase
    {
        private static List<Estacion> _estaciones = new List<Estacion>
        {
                new Estacion { IdEstacion = 1, Nombre = "Calle 85", IdZona = 1, Estado = true },
                new Estacion { IdEstacion = 2, Nombre = "Calle 72", IdZona = 2, Estado = true },
                new Estacion { IdEstacion = 3, Nombre = "Virrey", IdZona = 1, Estado = true },
        };
        // GET: api/<EstacionesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estaciones);
        }

        // GET api/<EstacionesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_estaciones.FirstOrDefault(x=>x.IdEstacion == id));

        }

        // POST api/<EstacionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EstacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
public class Estacion
{
    public int IdEstacion { get; set; }
    public string Nombre { get; set; }
    public int IdZona { get; set; }
    public bool Estado { get; set; }
}
