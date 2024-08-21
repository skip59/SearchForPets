namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record PetPhoto
    {
        public string Path { get; init; } = string.Empty;
        public bool IsMain { get; init; }
    }
}
