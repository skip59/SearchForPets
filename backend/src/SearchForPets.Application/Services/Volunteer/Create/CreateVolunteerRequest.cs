using SearchForPets.Application.DTO.VolunteerDtos;

namespace SearchForPets.Application.Services.Volunteer.Create
{
    public record CreateVolunteerRequest(
    FullNameDto FullName,
    string Description,
    int ExperienceInYears,
    string PhoneNumber,
    List<SocialNetworkDto>? SocialNetworkList,
    List<RequsistesDto>? Requsistes)
;
}
