using Domain;

namespace ZooPark.DTO;

public class AddAnimalRequest
{
    public string Name { get; set; }
    public TypeAnimal TypeAnimal { get; set; }
    public int Age { get; set; }
}
