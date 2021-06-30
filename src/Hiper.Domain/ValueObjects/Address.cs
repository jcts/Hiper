namespace Hiper.Domain.ValueObjects
{
    public class Address : ValueObject<Address>
    {
        public long ZipCode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string MoreInfo { get; set; }
    }
}
