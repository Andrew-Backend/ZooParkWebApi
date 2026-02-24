using Application;
using Domain;

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
    public IActionResult Add([FromBody] AddAnimalDto dto)
    {
        Animal animal = new Animal();
        animal.AnimalId = dto.AnimalId;
        animal.Name = dto.Name;
        animal.TypeAnimal = dto.TypeAnimal;
        animal.Age = dto.Age;
        
        _service.AddAnimal(animal);
        return Ok();
    }
}