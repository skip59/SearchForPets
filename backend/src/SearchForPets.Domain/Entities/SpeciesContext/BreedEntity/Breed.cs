using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.SpeciesContext.BreedEntity
{
    public class Breed : Entity<BreedId>
    {
        private Breed(BreedId id) : base(id) { }

        private Breed(BreedId id, Title title) : base(id)
        {
            Title = title;
        }
        public Title Title { get; private set; }

        //В задании 5.1 будет добавлен класс Result
        public static Breed Create(BreedId id, Title title) => new(id, title);
    }
}
