using Microsoft.AspNetCore.Mvc;

namespace App_Example_Resp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RutasController : ControllerBase
{

    private static List<Ruta> _rutas = new List<Ruta>
    {
            new Ruta { IdRuta = 1, Nombre = "Calle 85"},
            new Ruta { IdRuta = 2, Nombre = "Calle 72"},
            new Ruta {IdRuta = 3, Nombre = "Virrey"},
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_rutas);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_rutas.FirstOrDefault(x => x.IdRuta == id));

    }

    [HttpGet("GetAlternativeRoute/{idRoute}")]
    public IActionResult GetAlternativeRoute(int idRoute)
    {
        return Ok(_rutas.FirstOrDefault(x => x.IdRuta == idRoute+1));
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
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

public class Ruta
{
    public int IdRuta { get; set; }
    public string Nombre { get; set; }
}
