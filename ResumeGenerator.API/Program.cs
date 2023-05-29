
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
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
        builder.Services.AddSwaggerGen(options => options.SwaggerDoc("v1", new OpenApiInfo { Title = "ResumeGeneratorApi", Version = "v1", Description = "Fill in the blanks, choose a template and download your CV in minutes." }));

        // Add DB layer
        builder.Services
            .AddScoped<IPersonRepository, PersonRepository>()
            .AddScoped<IAddressRepository, AddressReposity>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("ClientPermission", policy =>
            {
                policy.AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("https://localhost:7254", "http://localhost:5218")
                .AllowCredentials();
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseDeveloperExceptionPage();
            app.UseHsts();
        }

        app.UseSwagger();

        app.UseSwaggerUI(options => options.SwaggerEndpoint(
            "/swagger/v1/swagger.json",
            "ResumeGenerator v1"));

        app.UseHttpsRedirection();

        app.UseCors("ClientPermission");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}