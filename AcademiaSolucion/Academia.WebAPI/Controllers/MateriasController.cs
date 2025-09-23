using Microsoft.AspNetCore.Mvc;
using Academia.Domain.Model;
using Academia.Domain.Services;

namespace Academia.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MateriasController : ControllerBase
{
    private readonly IMateriaService _service;

    public MateriasController(IMateriaService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var materia = _service.GetById(id);
        if (materia == null) return NotFound();
        return Ok(materia);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Materia materia)
    {
        _service.Add(materia);
        return CreatedAtAction(nameof(Get), new { id = materia.Id }, materia);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Materia materia)
    {
        materia.Id = id;
        _service.Update(materia);
        return Ok(materia);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}
