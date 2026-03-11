using Domain;

namespace ZooPark.DTO;

public class AddAnimalDTO
{
    public string Name { get; set; }
    public TypeAnimalEnum TypeAnimal { get; set; }
    public int Age { get; set; }
    
    public int ZooId { get; set; }
}
