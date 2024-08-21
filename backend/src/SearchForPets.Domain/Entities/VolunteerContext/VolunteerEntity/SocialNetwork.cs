namespace SearchForPets.Domain.Entities.VolunteerContext.Volunteer
{
    public record SocialNetwork
    {
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
