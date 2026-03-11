using Application;
using Domain;

using ZooPark.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ZooPark;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalManagementService _service;

    public AnimalsController(IAnimalManagementService service)
    {
        _service = service;
    }

    [HttpPost ("AddAnimal")]
    public IActionResult AddAnimal([FromBody] AnimalDTO dto)
    {
        Animal animal = new Animal();
        animal.Name = dto.Name;
        animal.TypeAnimal = dto.TypeAnimal;
        animal.Age = dto.Age;
        animal.ZooId = dto.ZooId;
        
        _service.Add(animal);
        return Ok();
    }

    [HttpDelete ("DeleteAnimalById")]
    public IActionResult RemoveAnimal(int id)
    {
        _service.Remove(id);
        return Ok();
    }

    [HttpGet ("GetAllAnimalsFromZoo")]
    public async Task<ActionResult<List<GetAllAnimalDTO>>> GetAnimals(int zooId)
    {
        var animals = await _service.GetAll(zooId);
        
        var result = animals.Select(a => new GetAllAnimalDTO
        {
            AnimalId = a.AnimalId,
            Name = a.Name,
            TypeAnimal = a.TypeAnimal,
            Age = a.Age
        }).ToList();

        return Ok(result);
    }
}