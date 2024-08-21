namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record PetPhoto
    {
        private PetPhoto(string path, bool isMain)
        {
            Path = path;
            IsMain = isMain;
        }

        public string Path { get; }
        public bool IsMain { get; }

        public static PetPhoto Create(string path, bool isMain) => new(path, isMain);

    }
}
