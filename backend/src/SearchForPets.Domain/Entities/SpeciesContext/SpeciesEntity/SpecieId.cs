namespace SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity
{
    public record SpecieId
    {
        private SpecieId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static SpecieId NewPetId() => new(Guid.NewGuid());
        public static SpecieId Empty() => new(Guid.Empty);
        public static SpecieId Create(Guid id) => new(id);
    }
}
