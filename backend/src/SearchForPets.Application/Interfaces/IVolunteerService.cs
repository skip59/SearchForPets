using SearchForPets.Application.Services.Volunteer.Create;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Application.Interfaces
{
    public interface IVolunteerService
    {
       public Task<VolunteerId> Create(CreateVolunteerRequest request, CancellationToken cancellationToken);
    }
}
