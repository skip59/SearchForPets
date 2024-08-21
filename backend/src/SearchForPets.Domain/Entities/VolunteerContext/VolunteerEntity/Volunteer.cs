using SearchForPets.Domain.Entities.Common;
using SearchForPets.Domain.Entities.VolunteerContext.PetEntity;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Domain.Entities.VolunteerContext.Volunteer
{
    public class Volunteer : Entity<VolunteerId>
    {
        private readonly List<Pet> _pets = [];

        private Volunteer(VolunteerId id, 
            FullName fullName, 
            string description, 
            int yearsOfExperience, 
            PhoneNumber phone) : base(id)
        {
            FullName=fullName;
            Description=description;
            YearsOfExperience=yearsOfExperience;
            Phone=phone;
        }

        private Volunteer(VolunteerId id) : base(id) { }


        public FullName FullName { get; set; }
        public string Description { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }
        public int NumberOfPetAbleHome => _pets.Count(p => p.Status == Status.FindedHome);
        public int NumberOfPetLookingHome => _pets.Count(p => p.Status == Status.FindHome);
        public int NumberOfPetBeingTreated => _pets.Count(p => p.Status == Status.NeedHelp);
        public PhoneNumber Phone { get; }
        public SocialNetworkDetails? SocialNetworks { get; }
        public RequisiteDetails? Requisites { get; }
        public IReadOnlyList<Pet> Pets => _pets;


        //В задании 5.1 будет добавлен класс Result
        public static Volunteer Create(VolunteerId id,
            FullName fullName,
            string description,
            int yearsOfExperience,
            PhoneNumber phone) => new(id, 
                fullName, 
                description, 
                yearsOfExperience, 
                phone);
    }
}
