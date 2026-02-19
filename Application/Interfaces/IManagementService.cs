using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application;

public interface IManagementService
{
    Task AddAnimal(Animal animal);
    Task RemoveAnimal(int Id);
    Task<List<Animal>> GetAllAnimals();
}