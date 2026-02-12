using Domain;
using Aplication;
namespace ZooPark.Infrastructure;

public static class SeedAnimal
{

    static public Zoo SeedData()
    {
        Zoo ZooPark = new Zoo();

        ZooPark.AddAnimal("Tiger", TypeAnimal.Mammal, 6);
        ZooPark.AddAnimal("Crocodile", TypeAnimal.Reptile, 10);
        ZooPark.AddAnimal("Goose", TypeAnimal.Bird, 4);
        ZooPark.AddAnimal("Frog", TypeAnimal.Amphibian, 1);
        ZooPark.AddAnimal("Pheasant", TypeAnimal.Bird, 2);
        ZooPark.AddAnimal("Duck", TypeAnimal.Bird, 3);

        return ZooPark;
    }
}
