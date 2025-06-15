
using Microsoft.EntityFrameworkCore;
using StockSystem.Configurations.Application;
using StockSystem.Configurations.Repositories;
using SystemStock.Infrastructure.EFCore.Context;

namespace StockSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();            

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddControllers();

            //COnfigiuracion Cors

            var corsPolicyName = "_corsPolicy";
            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy(corsPolicyName, plc => plc.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });


            builder.Services.AddDbContext<StockSystemContext>(p=>p.UseSqlServer("Name=ConnectionStrings:STOCKSYSTEM"));

            // Add Application Repositories
            builder.Services.AddRepositories();

            // Add Application Services
            builder.Services.AddApplication();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseCors(corsPolicyName);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
