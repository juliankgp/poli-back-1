using Microsoft.AspNetCore.Mvc;


namespace App_Example_Resp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ZonasController : ControllerBase
{
    private static List<Zona> _zonas = new List<Zona>
    {
            new Zona { Nombre = "SUR", IdZona = 1},
            new Zona { Nombre = "SUR-OCCIDENTE", IdZona = 2},
            new Zona { Nombre = "SUR-ORIENTE", IdZona = 3},
            new Zona { Nombre = "NORTE", IdZona = 4},
            new Zona { Nombre = "NOR-OCCIDENTE", IdZona = 5},
            new Zona { Nombre = "NOR-ORIENTE", IdZona = 6},
    };

    // GET: api/<ZonasController>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_zonas);
    }

    // GET api/<ZonasController>/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_zonas.FirstOrDefault(x => x.IdZona == id));

    }

    // POST api/<ZonasController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ZonasController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ZonasController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

public class Zona
{
    public int IdZona { get; set; }
    public string Nombre { get; set; }
}
