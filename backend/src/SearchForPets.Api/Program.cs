using SearchForPets.Infrastructure.Postgres.Extentions;
namespace SearchForPets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Database") ?? throw new ApplicationException("Не найден путь к БД");

            builder.Services.InitDbContext(connectionString);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
