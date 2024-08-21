namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record AnthropometricIndicators
    {
        private AnthropometricIndicators(double weight, double growth)
        {
            Weight = weight;
            Growth = growth;
        }

        public double Weight { get; }
        public double Growth { get; }

        public static AnthropometricIndicators Create(double weight, double growth) => new(weight, growth);
    }
}
