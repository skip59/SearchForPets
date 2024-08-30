using SearchForPets.Domain.Entities.Common;
using SearchForPets.Domain.Entities.SpeciesContext.BreedEntity;

namespace SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity
{
    public class Specie : Entity<SpecieId>
    {
        private readonly List<Breed> _breeds = [];
        private Specie(SpecieId id) : base(id) { }

        private Specie(SpecieId id, Title title) : base(id)
        {
            Title=title;
        }

        public Title Title { get; private set; }
        public IReadOnlyList<Breed> Breeds => _breeds;


        //В задании 5.1 будет добавлен класс Result
        public static Specie Create(SpecieId id, Title title) => new(id, title);
    }
}
