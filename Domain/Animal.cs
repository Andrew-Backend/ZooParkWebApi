namespace Domain;

public class Animal
{
    public string Name { get; set; }
    public TypeAnimal Type { get; set; }
    public int Age { get; set; }
    
    public Animal(string name, TypeAnimal type, int age)
    {
        Name = name;
        Type = type;
        Age = age;
    }
}