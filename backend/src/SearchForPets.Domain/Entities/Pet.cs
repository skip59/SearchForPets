namespace SearchForPets.Domain.Entities
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string HealthAbout { get; set; }
        public string Address { get; set; }
        public double Weight { get; set; }
        public double Growth { get; set; }
        public string Phone { get; set; }
        public bool IsCastrated { get; set; }
        public DateOnly BirthDay { get; set; }
        public bool IsVaccinated { get; set; }
        public Guid VolunteerId { get; set; }
        public string Status { get; set; }
        public string DetailsForHelp { get; set; }
        public DateTime AtCreated { get; set; }
    }
}
