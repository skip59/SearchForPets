using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Application.Interfaces
{
    public interface IVolunteerRepository
    {
        Task Create(Volunteer volunteer, CancellationToken cancellationToken = default);
    }
}