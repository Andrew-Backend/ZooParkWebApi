using Domain;

namespace Aplication;

public class ManagementService : IManagementService
{
    private readonly Zoo zoo;
    
    public ManagementService(Zoo zoo)
    {
        this.zoo = zoo;
    }
    
    public void AddAnimal(string name, TypeAnimalEnum type, int age)
    {
        Animal animal = new Animal(name, type, age);
        if (age < 0)
        {
            throw new InvalidOperationException("Age cannot be negative!");
        }else{
            zoo.AddAnimal(animal);
        }
    }

    public void RemoveAnimal(string name)
    {
        if (zoo.Animals != null && zoo.Animals.Count > 0)
            zoo.DestroyAnimal(name);
        
    }
    
}