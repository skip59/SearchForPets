namespace SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity
{
    public record SocialNetworkDetails
    {
        private SocialNetworkDetails()
        {
        }

        public SocialNetworkDetails(List<SocialNetwork> socialNetworks)
        {
            SocialNetworks = socialNetworks;
        }
        public IReadOnlyList<SocialNetwork> SocialNetworks { get; }

        public static SocialNetworkDetails Create(List<SocialNetwork> socialNetworks) => new(socialNetworks);
    }
}
