using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application;
using ZooPark.Infrastructure.EntityFramework;



namespace ZooPark.Test.Extensions;

public static class EntityFrameworkExtension
{
    public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"))
        );
        
        services.AddScoped<IAppDbContext, AppDbContext>();
    }
}