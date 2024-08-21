using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public class Pet : Entity<PetId>
    {
        private Pet(PetId id, 
            string name, 
            string animalType, 
            string description, 
            string breed, 
            string color, 
            string healthAbout, 
            Address address, 
            AnthropometricIndicators anthropometricIndicators, 
            PhoneNumber phone, 
            bool isCastrated, 
            DateOnly birthDay, 
            bool isVaccinated, 
            Status? status) : base (id)
        {
            Name=name;
            AnimalType=animalType;
            Description=description;
            Breed=breed;
            Color=color;
            HealthAbout=healthAbout;
            Address=address;
            AnthropometricIndicators=anthropometricIndicators;
            Phone=phone;
            IsCastrated=isCastrated;
            BirthDay=birthDay;
            IsVaccinated=isVaccinated;
            Status=status;
        }

        private Pet(PetId id) : base(id) {}

        public string Name { get; set; } = string.Empty;
        public string AnimalType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string HealthAbout { get; set; } = string.Empty;
        public Address Address { get; }
        public AnthropometricIndicators AnthropometricIndicators { get; }
        public PhoneNumber Phone { get; }
        public bool IsCastrated { get; set; }
        public DateOnly BirthDay { get; set; }
        public bool IsVaccinated { get; set; }
        public Status? Status { get; set; }
        public RequisiteDetails? DetailsForHelp { get; }
        public PhotoDetails? PhotosDetails { get; }
        public DateTime AtCreated { get; set; }


        //В задании 5.1 будет добавлен класс Result
        public static Pet Create(PetId id,
            string name,
            string animalType,
            string description,
            string breed,
            string color,
            string healthAbout,
            Address address,
            AnthropometricIndicators anthropometricIndicators,
            PhoneNumber phone,
            bool isCastrated,
            DateOnly birthDay,
            bool isVaccinated,
            Status? status) => new(id, 
                name, 
                animalType, 
                description, 
                breed, 
                color, 
                healthAbout, 
                address, 
                anthropometricIndicators, 
                phone, 
                isCastrated, 
                birthDay, 
                isVaccinated, 
                status);
    }
}


