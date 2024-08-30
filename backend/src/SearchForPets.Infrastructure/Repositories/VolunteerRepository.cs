using SearchForPets.Application.Interfaces;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;
using SearchForPets.Infrastructure.Postgres.Context;

namespace SearchForPets.Infrastructure.Postgres.Repositories
{
    public class VolunteerRepository(ApplicationDbContext dbContext) : IVolunteerRepository
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        public async Task Create(Volunteer volunteer, CancellationToken cancellationToken)
        {
            _dbContext.Volunteers.Add(volunteer);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
