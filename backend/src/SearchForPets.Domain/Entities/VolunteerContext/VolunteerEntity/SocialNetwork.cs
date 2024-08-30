using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.VolunteerContext.Volunteer
{
    public record SocialNetwork
    {
        private SocialNetwork(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; }
        public string Url { get; }

        public static SocialNetwork Create(string title, string url) => new(title, url);
    }
}
