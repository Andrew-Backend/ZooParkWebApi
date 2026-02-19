using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application;
using Domain;

namespace ZooPark.Infrastructure.EntityFramework;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Zoo>  Zoo { get; set; }
    public DbSet<Animal>  Animals { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}