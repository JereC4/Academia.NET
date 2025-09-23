using Microsoft.AspNetCore.Mvc;
using Academia.Domain.Model;
using Academia.Domain.Services;

namespace Academia.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfesoresController : ControllerBase
{
    private readonly IProfesorService _service;

    public ProfesoresController(IProfesorService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var profesor = _service.GetById(id);
        if (profesor == null) return NotFound();
        return Ok(profesor);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Profesor profesor)
    {
        _service.Add(profesor);
        return CreatedAtAction(nameof(Get), new { id = profesor.Id }, profesor);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Profesor profesor)
    {
        profesor.Id = id;
        _service.Update(profesor);
        return Ok(profesor);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}

