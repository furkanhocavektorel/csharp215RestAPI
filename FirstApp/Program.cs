using FirstApp.Service;
using Mvc.Models.Context;

namespace FirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // IOC ve DI
            // Inversion of control
            // dependency injection

            builder.Services.AddScoped<ICustomerService,CustomerService>();
            builder.Services.AddScoped<NorthwindContext, NorthwindContext>();
            builder.Services.AddScoped<IAdminService, AdminService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}