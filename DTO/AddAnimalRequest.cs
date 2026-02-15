using Domain;

namespace ZooPark.DTO;

public class AddAnimalRequest
{
    public string Name { get; set; }
    public TypeAnimalEnum TypeAnimalEnum { get; set; }
    public int Age { get; set; }
}
