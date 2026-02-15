using Domain;
using Aplication;
namespace ZooPark.Infrastructure;

public static class SeedAnimal
{

    static public Zoo SeedData()
    {
        Zoo ZooPark = new Zoo();

        ZooPark.AddAnimal("Tiger", TypeAnimalEnum.Mammal, 6);
        ZooPark.AddAnimal("Crocodile", TypeAnimalEnum.Reptile, 10);
        ZooPark.AddAnimal("Goose", TypeAnimalEnum.Bird, 4);
        ZooPark.AddAnimal("Frog", TypeAnimalEnum.Amphibian, 1);
        ZooPark.AddAnimal("Pheasant", TypeAnimalEnum.Bird, 2);
        ZooPark.AddAnimal("Duck", TypeAnimalEnum.Bird, 3);

        return ZooPark;
    }
}
