namespace SearchForPets.Domain.Entities.Common
{
    public record Requisite
    {
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
    }
}


