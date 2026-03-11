using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application;

public interface IAnimalManagementService
{
    Task Add(Animal animal);
    Task Remove(int id);
    Task<List<Animal>> GetAll(int ZooId);
}