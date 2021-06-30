namespace Hiper.Domain.ValueObjects
{
    public class Phone : ValueObject<Phone>
    {
        public int CountryCode { get; set; }
        public int Ddd { get; set; }
        public int PhoneNumber { get; set; }

        public Phone() { }

        public Phone(int countrycode, int ddd, int phonenumber)
        {
            CountryCode = countrycode;

            Ddd = ddd;

            PhoneNumber = phonenumber;
        }

        public override string ToString()
            => $"+{CountryCode} ({Ddd}) {PhoneNumber}";
    }
}
