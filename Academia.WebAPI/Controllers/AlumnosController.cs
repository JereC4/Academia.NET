using Microsoft.AspNetCore.Mvc;
using Academia.Domain.Model;
using Academia.Domain.Services;

namespace Academia.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlumnosController : ControllerBase
{
    private readonly IAlumnoService _service;

    public AlumnosController(IAlumnoService service)
    {
        _service = service;
    }

    // GET: api/alumnos
    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    // GET: api/alumnos/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var alumno = _service.GetById(id);
        if (alumno == null) return NotFound();
        return Ok(alumno);
    }

    // POST: api/alumnos
    [HttpPost]
    public IActionResult Create([FromBody] Alumno alumno)
    {
        _service.Add(alumno);
        return CreatedAtAction(nameof(Get), new { id = alumno.IdAlumno }, alumno);
    }

    // PUT: api/alumnos/5
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Alumno alumno)
    {
        alumno.IdAlumno = id;
        _service.Update(alumno);
        return Ok(alumno);
    }

    // DELETE: api/alumnos/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}
