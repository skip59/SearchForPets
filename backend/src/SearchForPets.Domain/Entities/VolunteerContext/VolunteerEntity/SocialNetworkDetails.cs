using SearchForPets.Domain.Entities.VolunteerContext.Volunteer;

namespace SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity
{
    public class SocialNetworkDetails
    {
        private readonly List<SocialNetwork> _socialNetworks = [];

        public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks.AsReadOnly();

        public void AddSocialNetwork(SocialNetwork socialNetwork) => _socialNetworks.Add(socialNetwork);
    }
}
