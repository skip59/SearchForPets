using SearchForPets.Domain.Entities.VolunteerContext.Volunteer;

namespace SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity
{
    public record SocialNetworkDetails
    {
        public SocialNetworkDetails(List<SocialNetwork> socialNetworks)
        {
            SocialNetworks = socialNetworks;
        }
        public IReadOnlyList<SocialNetwork> SocialNetworks { get; }
    }
}
