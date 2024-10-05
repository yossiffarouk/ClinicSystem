using ClinicManagement;
using ClinicManagement.Data;
using ClinicMangmentSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<ClinicDbContext>(
                builder => builder.UseSqlServer(
                            new ConfigurationBuilder().AddJsonFile("appsettings.json")
                            .Build().GetConnectionString("constr"))
            );
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
        using(var context = new ClinicDbContext())
        {
            context.Database.EnsureCreated();

            if (!context.Set<Office>().Any())
            {
                context.Set<Office>().AddRange(SeedingData.LoadOffieces());
            }

            if(!context.Set<Doctor>().Any())
            {
                context.Set<Doctor>().AddRange(SeedingData.LoadDoctors());
            }

            if(!context.Set<SchedualeTime>().Any())
            {
                context.Set<SchedualeTime>().AddRange(SeedingData.LoadSchedualeTimes());
            }
            context.SaveChanges();
        }
        app.Run();

    }
}