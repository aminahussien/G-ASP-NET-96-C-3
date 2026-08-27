using System.Xml;

namespace Assignment2C_.Structs
{
    public struct Shipment
    {
        private string? trackingCode;
        private string description;
        private int weight;
        private decimal deliveryFees;
        private DeliveryAddress destination;

        public string? TrackingCode
        {
            get {
                return trackingCode;
            }
        }
        public string? Description {

            get {
                return description;
            }
            set {
                if (string.IsNullOrEmpty(value))
                    description = "description cannot be null or empty";
                description = value;
            }
        }
        public int Weight {
            get
            {
                return weight;
            }
            set {
                if (value > 0)
                    weight = value;
                weight = 0;
            }
        }
        public decimal DeliveryFees {
            get {
                return deliveryFees;
            }
            private set {
                if (value > 0)
                    deliveryFees = value;
                deliveryFees = 0;
            }
        }
        public DeliveryAddress Destination {
            get {
                return destination;
            }
            set {
                destination = value;
            }
        }

        public decimal EstimatedCost{
            get
            {
                return DeliveryFees + (Weight * 5);
            }
        }

        public Shipment(string code)
        {
            trackingCode = code;
            Description = "default";
            Weight = 0;
            DeliveryFees = 10;
            Destination= new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string code , string desc, int weight, decimal fees, DeliveryAddress address)
        { 
            trackingCode = code;
            Description = desc;
            Weight = weight;
            DeliveryFees = fees;
            Destination = address;
        }

        public void UpdateDeliveryFees(decimal newFees)
        {
            DeliveryFees = newFees;
        }

        public void PrintShipment()
        {
            Console.WriteLine("---Tracking Code: " + TrackingCode);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Weight: " + Weight + " KG");
            Console.WriteLine("Delivery Fee: " + DeliveryFees + " EGP");
            Console.WriteLine("Destination: " + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }

}
