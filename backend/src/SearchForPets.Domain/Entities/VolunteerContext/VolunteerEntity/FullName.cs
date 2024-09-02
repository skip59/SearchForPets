namespace SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity
{
    public record FullName
    {
        private FullName(string firstname, string secondName, string? lastName)
        {
            Firstname=firstname;
            SecondName=secondName;
            LastName=lastName ?? "";
        }

        public string Firstname { get; }
        public string SecondName { get; }
        public string LastName { get; }

        public static FullName Create(string firstName, string secondName, string? lastName) => new(firstName, secondName, lastName);
    }
}
