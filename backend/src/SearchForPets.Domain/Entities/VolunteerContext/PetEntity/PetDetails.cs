using SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity;

namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record PetDetails
    {
        private PetDetails() { }

        public PetDetails(SpecieId specieId, Guid breedId)
        {
            SpecieId = specieId;
            BreedId = breedId;
        }

        public SpecieId SpecieId { get; } 
        public Guid BreedId { get; }

    }
}
