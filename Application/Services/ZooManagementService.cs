using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application;

public class ZooManagementService : IManagementService <Zoo>
{
    private readonly IAppDbContext _dbContext;
    public ZooManagementService(IAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Add(Zoo zoo)
    {
        _dbContext.Zoo.Add(zoo); 
        _dbContext.SaveChangesAsync();
    }

    public async Task Remove(int id)
    {
        var zoo = await _dbContext.Zoo.FindAsync(id);
        _dbContext.Zoo.Remove(zoo);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Zoo>> GetAll()
    {
        return await _dbContext.Zoo.ToListAsync();
    }
}