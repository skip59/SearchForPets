using SearchForPets.Application.Interfaces;
using SearchForPets.Domain.Entities.Common;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Application.Services.Volunteer.Create
{
    public class CreateVolunteerHandler(IVolunteerRepository volunteerRepository) : IVolunteerService
    {
        private readonly IVolunteerRepository volunteerRepository = volunteerRepository;

        public async Task<VolunteerId> Create(
        CreateVolunteerRequest request,
        CancellationToken cancellationToken)
        {
            var phoneNumber = PhoneNumber.Create(request.PhoneNumber);

            var fullName = FullName.Create(
               request.FullName.FirstName,
               request.FullName.SecondName,
               request.FullName?.LastName);

            var socialNetworks = request.SocialNetworkList is not null 
                ? new SocialNetworkDetails(request.SocialNetworkList
                .Select(x => SocialNetwork.Create(x.Title, x.Url)) 
                .ToList()) 
                : new SocialNetworkDetails([]);

            var requisitesDetail = request.Requsistes is not null
                ? new RequisiteDetails(request.Requsistes
                .Select(x => Requisite.Create(x.Title, x.Description))
                .ToList()) 
                : new RequisiteDetails([]);

            var volunteer = Domain.Entities.VolunteerContext.VolunteerEntity.Volunteer.Create(
                VolunteerId.NewVolunteerId(),
                fullName,
                request.Description,
                request.ExperienceInYears,
                phoneNumber,
                socialNetworks,
                requisitesDetail);
                

            await volunteerRepository.Create(volunteer, cancellationToken);

            return volunteer.Id;
        }
    }
}
