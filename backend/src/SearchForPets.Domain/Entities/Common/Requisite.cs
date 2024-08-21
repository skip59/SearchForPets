namespace SearchForPets.Domain.Entities.Common
{
    public record Requisite
    {
        private Requisite(string title, string description)
        {
            Title=title;
            Description=description;
        }

        public string Title { get; }
        public string Description { get; }

        public static Requisite Create(string title, string description) => new(title, description);
    }
}


