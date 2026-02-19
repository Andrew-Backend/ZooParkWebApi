using Microsoft.EntityFrameworkCore;
using Domain;

namespace Application;

public interface IAppDbContext
{   
    DbSet<Zoo>  Zoo { get; set; }
    DbSet<Animal>  Animals { get; set; }
    Task<int> SaveChangesAcync();
    
}