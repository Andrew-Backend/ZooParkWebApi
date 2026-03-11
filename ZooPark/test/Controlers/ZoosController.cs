using Application;
using Application.DTOs.ZooDTOs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ZooPark;

[ApiController]
[Route("api/Zoos")]
public class ZoosController : ControllerBase
{
    private readonly IZooManagementService _service;
    
    public ZoosController(IZooManagementService service)
    {
        _service = service;
    }

    [HttpPost("AddZoo")]
    public IActionResult AddZoo([FromBody] ZooAddDTO dto)
    {
        Zoo zoo = new Zoo();
        zoo.Name = dto.Name;

        _service.Add(zoo);
        return Ok();
    }

    [HttpDelete("DeleteZoo")]
    public IActionResult DeleteZoo(int id)
    {
        _service.Remove(id);
        return Ok();
    }

    [HttpGet("GetAllZoos")]
    public async Task<ActionResult<List<GetAllZoosDTO>>> GetAllZoosAsync()
    {
        var animals = await _service.GetAll();
        
        var result = animals.Select(a => new GetAllZoosDTO()
        {
            Id = a.ZooId,
            Name = a.Name,

        }).ToList();

        return Ok(result);
    }
}