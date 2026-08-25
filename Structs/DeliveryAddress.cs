
namespace Assignment2C_.Structs
{
    internal struct DeliveryAddress
    {
        string city;
        string street;
        int buildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{this.city} --{this.street}-- {this.buildingNumber}";
        }
    }
}
