namespace Domain;

public class Zoo
{
    public List<Animal> animals = new List<Animal>();
    
    public void AddAnimal (string name, TypeAnimal type, int age) 
    {
        Animal newAnimal = new Animal(name, type, age);
        animals.Add(newAnimal);
    }
    
    public void AddAnimal (Animal newAnimal)
    {
            animals.Add(newAnimal);
    }

    public void DestroyAnimal(string name)
    {
        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Name == name)
            {
                animals.Remove(animals[i]);
                return;
            }
        }
    }
}