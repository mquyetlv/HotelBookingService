
using HotelBokingService.Connection;
using HotelBokingService.Repository;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace HotelBokingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<SqlConnectionFactory>(); 
            builder.Host.UseSerilog((context, services, configuration) => configuration
                .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services));

            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<RoomTypeRepository>();
            builder.Services.AddScoped<RoomRepository>();
            builder.Services.AddScoped<AmenityRepository>();
            builder.Services.AddScoped<RoomAmenityRepository>();

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
}
