namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public class PhotoDetails
    {

        private readonly List<PetPhoto> _petPhotos = [];

        public IReadOnlyList<PetPhoto> PetPhotos => _petPhotos.AsReadOnly();

        public void AddPetPhoto(PetPhoto petPhoto) => _petPhotos.Add(petPhoto);
    }
}
