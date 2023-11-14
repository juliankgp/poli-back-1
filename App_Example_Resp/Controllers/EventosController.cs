using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_Example_Resp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private static List<Evento> _eventos = new List<Evento>
    {
            new Evento { IdZona=1, IdEstacion =1, IdEvento =1, IdTipoEvento=4, Estado= true}
    };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_eventos.FirstOrDefault(x => x.IdEvento == id));

        }

        [HttpPost]
        public void Post([FromBody] Evento value)
        {
            _eventos.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

public class Evento
{
    public int IdEvento{ get; set; }
    public int IdZona{ get; set; }
    public int IdEstacion{ get; set; }
    public int IdTipoEvento{ get; set; }
    public bool Estado{ get; set; }
}