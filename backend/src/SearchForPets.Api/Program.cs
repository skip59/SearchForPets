using SearchForPets.Infrastructure.Postgres.Extentions;
using SearchForPets.Application.Extentions;
namespace SearchForPets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Database") ?? throw new ApplicationException("Не найден путь к БД");

            builder.Services.AddApplicationContext()
                            .InitDbContext(connectionString);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}
