using Domain;

namespace ZooPark.DTO;

public class GetAllAnimalDTO
{
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public TypeAnimalEnum TypeAnimal { get; set; }
    public int Age { get; set; }
}