using Application;
using Domain;
using Infrastructure;
using ZooPark.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ZooPark;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private readonly IManagementService _service;

    public AnimalsController(IManagementService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Add(AddAnimalDto dto)
    {
        _service.Add(dto.Name, dto.TypeAnimalEnum , dto.Age);
        return Ok();
    }
}