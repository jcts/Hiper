namespace Hiper.Domain.ValueObjects
{
    public class Phone : ValueObject<Phone>
    {
        public int CountryCode { get; set; }
        public int Ddd { get; set; }
        public int PhoneNumber { get; set; }
    }
}
