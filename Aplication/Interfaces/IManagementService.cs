using Domain;

namespace Aplication;

public interface IManagementService
{
    Task AddAnimal(Animal animal);
    Task RemoveAnimal(int Id);
    Task<List<Animal>> GetAllAnimals();
}