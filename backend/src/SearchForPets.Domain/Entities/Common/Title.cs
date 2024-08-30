namespace SearchForPets.Domain.Entities.Common
{
    public record Title
    {
        private Title(string value)
        {
            Value = value;
        }
        public string Value { get; }

        //В задании 5.1 буду использовать класс Result
        public static Title Create(string value) => new(value);
    }
}
