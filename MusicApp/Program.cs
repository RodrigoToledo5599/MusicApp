
using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using System;

namespace MusicApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AluraTunesContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
            //"Server=(localdb)\\MSSQLLocalDB;Database=AluraTunes;Trusted_Connection=True;TrustServerCertificate=True"
            app.Run();
        }
    }
}