
using System.Text.RegularExpressions;

namespace SearchForPets.Domain.Entities.Common
{
    public class PhoneNumber : ValueObject
    {
        private const string phoneRegex = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";

        public string Number { get; }

        private PhoneNumber(string number)
        {
            Number=number;
        }

        public static PhoneNumber Create(string input)
        {
            //В задании 5.1 буду использовать класс Result
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException();
            if (!Regex.IsMatch(input, phoneRegex)) throw new ArgumentException();

            return new PhoneNumber(input);
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }
    }
}
