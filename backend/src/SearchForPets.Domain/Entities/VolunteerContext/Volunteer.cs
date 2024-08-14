using SearchForPets.Domain.Entities.Common;
using SearchForPets.Domain.Entities.PetContext;

namespace SearchForPets.Domain.Entities.VolunteerContext
{
    public class Volunteer : Entity<VolunteerId>
    {
        private Volunteer(VolunteerId id) : base(id)
        {
        }

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
