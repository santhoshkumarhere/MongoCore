namespace MongoCore
{
    public class AddressModel
    {
        public string StreetAddress;
        public string City;
        public string State;
        public string ZipCode;
        public AddressModel(string streetAddress, string city, string state, string zipCode)
        {
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }
    }
}
