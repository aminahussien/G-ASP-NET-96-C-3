using Assignment2C_.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2C_.Classes
{
    public class Shipment
    {
        private string? trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFees;
        private DeliveryAddress destination;

        public string? TrackingCode
        {
            get
            {
                return trackingCode;
            }
        }
        public string? Description
        {

            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    description = "description cannot be null or empty";
                description = value;
            }
        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }
        public decimal DeliveryFees
        {
            get
            {
                return deliveryFees;
            }
            private set
            {
                if (value > 0)
                    deliveryFees = value;
                else
                    deliveryFees = 0;
            }
        }
        public DeliveryAddress Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public  virtual decimal EstimatedCost
        {
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
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string code, string desc, decimal weight, decimal fees, DeliveryAddress address)
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

    public class StandardShipment : Shipment
    {
        public StandardShipment(string code , string desc, decimal weight, decimal fees, DeliveryAddress address) : base(code, desc, weight, fees, address)
        {

        }


    }

    public class ExpressShipment : Shipment
    {

        public decimal extraFees;
        public decimal ExtraFee {

            get
            {
                return extraFees;
            }

            set
            {
                if(value>=0)
                    extraFees = value;

            }
        }

        public ExpressShipment(decimal exFees , string code, string desc, decimal weight, decimal fees, DeliveryAddress address) :base(code, desc, weight, fees, address)
        {
            ExtraFee = exFees;

        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFees + (Weight * 5) + ExtraFee;
            }
        }
    }

    public class InternationalShipment : Shipment
    {
        string destinationCountry;
        decimal customsFees;

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    destinationCountry = value;
                destinationCountry = "not found";
            }
        }

        public decimal CustomsFees
        {
            get
            {
                return customsFees;
            }
            set
            {
                if(value >=0 )
                    customsFees = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFees + (Weight * 5) + CustomsFees;
            }
        }

        public InternationalShipment(string destinationCountry, decimal customsFees, string code, string desc, decimal weight, decimal fees, DeliveryAddress address) : base(code, desc, weight, fees, address)
        {
            DestinationCountry = destinationCountry;
            CustomsFees = customsFees;
          
        }
    }
}
