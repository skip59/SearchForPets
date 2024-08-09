using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities
{
    public class Volunteer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }
        public int NumberOfPetAbleHome { get; set; }
        public int NumberOfPetLookingHome { get; set; }
        public int NumberOfPetBeingTreated { get; set; }
        public string Phone { get; set; } = string.Empty;
        public List<SocialNetwork> SocialNetworks { get; set; } = [];
        public List<Requisites> Requisites { get; set; } = [];
        public List<Pet> Pets { get; set; } = [];
    }
}
