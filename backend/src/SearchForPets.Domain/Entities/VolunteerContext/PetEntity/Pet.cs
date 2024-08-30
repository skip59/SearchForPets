using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public class Pet : Entity<PetId>
    {
        private Pet(PetId id, 
            string name, 
            string animalType, 
            string description, 
            PetDetails petDetails, 
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
            PetDetails=petDetails;
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

        public string Name { get; private set; } = string.Empty;
        public PetDetails PetDetails { get; private set; }
        public string AnimalType { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public string Color { get; private set; } = string.Empty;
        public string HealthAbout { get; private set; } = string.Empty;
        public Address Address { get; }
        public AnthropometricIndicators AnthropometricIndicators { get; }
        public PhoneNumber Phone { get; }
        public bool IsCastrated { get; private set; }
        public DateOnly BirthDay { get; private set; }
        public bool IsVaccinated { get; private set; }
        public Status? Status { get; private set; }
        public RequisiteDetails? DetailsForHelp { get; }
        public PhotoDetails? PhotosDetails { get; }
        public DateTime AtCreated { get; private set; }


        //В задании 5.1 будет добавлен класс Result
        public static Pet Create(PetId id,
            string name,
            string animalType,
            string description,
            PetDetails petDetails,
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
                petDetails, 
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


