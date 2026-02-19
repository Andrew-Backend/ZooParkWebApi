using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Application;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace ZooPark.Infrastructure.EntiyFramework;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Zoo>  Zoo { get; set; }
    public DbSet<Animal>  Animals { get; set; }

    public Task<int> SaveChangesAcync()
    {
        return base.SaveChangesAsync();
    }
}