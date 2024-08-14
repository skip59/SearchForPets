using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.PetContext
{
    public class Pet : Entity<PetId>
    {
        private Pet(PetId id) : base(id)
        {
        }
        public string Name { get; set; } = string.Empty;
        public string AnimalType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string HealthAbout { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double Weight { get; set; }
        public double Growth { get; set; }
        public string Phone { get; set; } = string.Empty;
        public bool IsCastrated { get; set; }
        public DateOnly BirthDay { get; set; }
        public bool IsVaccinated { get; set; }
        public Status? Status { get; set; }
        public List<Requisites> DetailsForHelp { get; set; } = [];
        public List<PetPhoto> PetPhotos { get; set; } = [];
        public DateTime AtCreated { get; set; }
    }
}


