namespace SearchForPets.Domain.Entities.VolunteerContext
{
    public class SocialNetwork
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
