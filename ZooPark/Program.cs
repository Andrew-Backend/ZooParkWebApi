using Application;
using ZooPark.Infrastructure.EntityFramework;
using ZooPark.Test.Extensions;

namespace ZooPark;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
  
        builder.Services.AddEntityFramework(builder.Configuration);

        builder.Services.AddScoped<IAppDbContext>(provider => 
            provider.GetRequiredService<AppDbContext>());
        
        builder.Services.AddAuthorization();
        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
       
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddScoped<IManagementService, ManagementService>();
        
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(); 
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}