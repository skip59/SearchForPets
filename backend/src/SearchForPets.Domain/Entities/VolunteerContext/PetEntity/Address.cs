using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Domain.Entities.VolunteerContext.PetEntity
{
    public record Address
    {
        private Address(string city, string street, int houseNumber, int flatNumber)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }

        public string City { get; }
        public string Street { get; }
        public int HouseNumber { get; }
        public int FlatNumber { get; }

        public static Address Create(string City, string Street, int HouseNumber, int FlatNumber) => new(City, Street, HouseNumber, FlatNumber);
    }
}
