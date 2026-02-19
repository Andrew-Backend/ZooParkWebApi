using Microsoft.EntityFrameworkCore;
using ZooPark.Infrastructure.EntiyFramework;


namespace ZooPark.Test.Extensions;

public static class EntityFrameworkExtension
{
    public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"))
        );
    }
}