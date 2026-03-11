using System;
using System.Collections.Generic;
using Domain;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application;

public class AnimalManagementService : IManagementService <Animal>
{
    private readonly IAppDbContext _zoo;
    
    public AnimalManagementService(IAppDbContext zoo)
    {
        _zoo = zoo;
    }
    
    public async Task Add(Animal animal)
    {
        if (animal.Age < 0)
        {
            throw new InvalidOperationException("Age cannot be negative!");
        }else{
            _zoo.Animals.Add(animal);
            await _zoo.SaveChangesAsync();
        }
    }

    public async Task Remove(int  id)
    {
        var animal = await _zoo.Animals.FindAsync(id);
        _zoo.Animals.Remove(animal);
        await _zoo.SaveChangesAsync();
    }

    public async Task<List<Animal>> GetAll()
    {
        return await _zoo.Animals.ToListAsync();
    }
}