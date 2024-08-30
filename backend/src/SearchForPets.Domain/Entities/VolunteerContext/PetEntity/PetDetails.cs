using SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity;

namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record PetDetails
    {
        private PetDetails() { }

        private PetDetails(SpecieId specieId, Guid breedId)
        {
            SpecieId = specieId;
            BreedId = breedId;
        }

        public SpecieId SpecieId { get; } 
        public Guid BreedId { get; }


        //В задании 5.1 будет добавлен класс Result
        public static PetDetails Create (SpecieId specieId, Guid breedId) => new(specieId, breedId);
    }
}
