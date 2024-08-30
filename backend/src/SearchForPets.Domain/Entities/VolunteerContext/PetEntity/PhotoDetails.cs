namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record PhotoDetails
    {
        private PhotoDetails()
        {
        }

        public PhotoDetails(List<PetPhoto> petPhotos)
        {
            PetPhotos = petPhotos;
        }
        public IReadOnlyList<PetPhoto> PetPhotos { get; }
    }
}
