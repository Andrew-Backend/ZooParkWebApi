using System.Data.Entity;
using Domain;

namespace Aplication;

public class ManagementService : IManagementService
{
    private readonly IAppDbContext _zoo;
    
    public ManagementService(IAppDbContext zoo)
    {
        _zoo = zoo;
    }
    
    public async Task AddAnimal(Animal animal)
    {
        
        if (animal.Age < 0)
        {
            throw new InvalidOperationException("Age cannot be negative!");
        }else{
            _zoo.Animals.Add(animal);
            await _zoo.SaveChanges();
        }
    }

    public async Task RemoveAnimal(int  id)
    {
        var animal = await _zoo.Animals.FindAsync(id);
        _zoo.Animals.Remove(animal);
    }

    public async Task<List<Animal>> GetAllAnimals()
    {
        return await _zoo.Animals.ToListAsync();
    }
}