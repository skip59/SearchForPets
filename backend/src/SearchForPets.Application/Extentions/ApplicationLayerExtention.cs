using Microsoft.Extensions.DependencyInjection;
using SearchForPets.Application.Interfaces;
using SearchForPets.Application.Services.Volunteer.Create;

namespace SearchForPets.Application.Extentions
{
    public static class ApplicationLayerExtention
    {
        public static IServiceCollection AddApplicationContext(this IServiceCollection services)
        {
            services.AddScoped<IVolunteerService, CreateVolunteerHandler>();
            return services;
        }
    }
}
