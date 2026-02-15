using Aplication;
using Microsoft.EntityFrameworkCore;

namespace ZooPark.Infrastructure.EntiyFramework;

public class AppDbContext : IAppDbContext
{
    public DbSet<Zoo>  Zoo { get; set; }
    public DbSet<Animal>  Animals { get; set; }

    public async Task<int> SaveChanges()
    {
        
    }
}