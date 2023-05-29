
using Microsoft.EntityFrameworkCore;
using ResumeGenerator.Core;
using ResumeGenerator.Services;

namespace ResumeGenerator.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<ResumeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ResumeDb")));
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add DB layer
        builder.Services
            .AddScoped<IPersonRepository, PersonRepository>()
            .AddScoped<IAddressRepository, AddressReposity>();

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