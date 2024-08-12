using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SearchForPets.Infrastructure.Postgres.Context;

namespace SearchForPets.Infrastructure.Postgres.Extentions
{
    public static class DbContextExtention
    {
        public static void InitDbContext (this IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseNpgsql(ConnectionString));
        }
    }
}
