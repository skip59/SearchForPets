namespace SearchForPets.Domain.Entities.VolunteerContext
{
    public record VolunteerId
    {
        private VolunteerId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static VolunteerId NewVolunteerId() => new(Guid.NewGuid());
        public static VolunteerId Empty() => new(Guid.Empty);
    }
}
