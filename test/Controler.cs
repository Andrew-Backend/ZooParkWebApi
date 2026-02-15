using Aplication;
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
    public IActionResult Add(AddAnimalRequest request)
    {
        _service.AddAnimal(request.Name, request.TypeAnimalEnum , request.Age);
        return Ok();
    }
}