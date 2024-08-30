using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SearchForPets.Application.Interfaces;
using SearchForPets.Infrastructure.Postgres.Context;
using SearchForPets.Infrastructure.Postgres.Repositories;

namespace SearchForPets.Infrastructure.Postgres.Extentions
{
    public static class DbContextExtention
    {
        public static IServiceCollection InitDbContext (this IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseNpgsql(ConnectionString));
            services.AddScoped<IVolunteerRepository, VolunteerRepository>();
            return services;
        }
    }
}
