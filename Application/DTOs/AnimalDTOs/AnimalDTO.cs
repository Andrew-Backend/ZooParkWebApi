using Domain;

namespace ZooPark.DTO;

public class AnimalDTO
{
    public string Name { get; set; }
    public TypeAnimalEnum TypeAnimal { get; set; }
    public int Age { get; set; }
    
    public int ZooId { get; set; }
}
