using SearchForPets.Domain.Entities.Common;
using SearchForPets.Domain.Entities.VolunteerContext.PetEntity;


namespace SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity
{
    public class Volunteer : Entity<VolunteerId>
    {
        private readonly List<Pet> _pets = [];

        private Volunteer(VolunteerId id, 
            FullName fullName, 
            string description, 
            int yearsOfExperience, 
            PhoneNumber phone, 
            SocialNetworkDetails socialNetworkDetails,
            RequisiteDetails requisiteDetails) : base(id)
        {
            FullName=fullName;
            Description=description;
            YearsOfExperience=yearsOfExperience;
            Phone=phone;
            SocialNetworks = socialNetworkDetails;
            Requisites = requisiteDetails;
        }

        private Volunteer(VolunteerId id) : base(id) { }


        public FullName FullName { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public int YearsOfExperience { get; private set; }
        public int NumberOfPetAbleHome => _pets.Count(p => p.Status == Status.FindedHome);
        public int NumberOfPetLookingHome => _pets.Count(p => p.Status == Status.FindHome);
        public int NumberOfPetBeingTreated => _pets.Count(p => p.Status == Status.NeedHelp);
        public PhoneNumber Phone { get; private set; }
        public SocialNetworkDetails SocialNetworks { get; private set; }
        public RequisiteDetails Requisites { get; private set; }
        public IReadOnlyList<Pet> Pets => _pets;


        //В задании 5.1 будет добавлен класс Result
        public static Volunteer Create(VolunteerId id,
            FullName fullName,
            string description,
            int yearsOfExperience,
            PhoneNumber phone, 
            SocialNetworkDetails socialNetworkDetails, 
            RequisiteDetails requisiteDetails) => new(id, 
                fullName, 
                description, 
                yearsOfExperience, 
                phone, 
                socialNetworkDetails, 
                requisiteDetails);

        public void UpdateSocialNetworks(SocialNetworkDetails socialNetworkDetails) => SocialNetworks = socialNetworkDetails;
        public void UpdateRequisites(RequisiteDetails requisitesDetails) => Requisites = requisitesDetails;
    }
}
