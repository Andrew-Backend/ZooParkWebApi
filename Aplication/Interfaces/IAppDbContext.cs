using System.Data.Entity;
using Domain;

namespace Aplication;

public interface IAppDbContext
{   
    DbSet<Zoo>  Zoo { get; set; }
    DbSet<Animal>  Animals { get; set; }
    Task<int> SaveChanges();
    
}