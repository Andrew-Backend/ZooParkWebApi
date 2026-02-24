namespace Domain;

public class Animal
{
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public TypeAnimalEnum TypeAnimal { get; set; }
    public int Age { get; set; }
    
    public int ZooId { get; set; }
    
    public Zoo Zoo { get; set; }
}