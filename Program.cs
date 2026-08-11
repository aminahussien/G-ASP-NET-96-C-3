namespace Assignment2C_
{
    public class DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street} Street, {City}";
        }
    }

    public class Driver
    {
        public string DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(string driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }

    public class Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            protected set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown City", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, double weight,
                         decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description : " + Description);
            Console.WriteLine("Weight : " + Weight + " KG");
            Console.WriteLine("Delivery Fee : " + DeliveryFee + " EGP");
        }
    }


    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode) : base(trackingCode) { }

        public StandardShipment(string trackingCode, string description, double weight,
                                 decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine("--------------------------------------------");
            base.PrintShipment();
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }

    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(string trackingCode, decimal extraFee) : base(trackingCode)
        {
            ExtraFee = extraFee;
        }

        public ExpressShipment(string trackingCode, string description, double weight,
                                decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5) + ExtraFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine("--------------------------------------------");
            base.PrintShipment();
            Console.WriteLine("Extra Fee : " + ExtraFee + " EGP");
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }


    public class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }

        public InternationalShipment(string trackingCode, string destinationCountry, decimal customsFee)
            : base(trackingCode)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public InternationalShipment(string trackingCode, string description, double weight,
                                      decimal deliveryFee, DeliveryAddress destination,
                                      string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5) + CustomsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine("--------------------------------------------");
            base.PrintShipment();
            Console.WriteLine("Destination Country : " + DestinationCountry);
            Console.WriteLine("Customs Fee : " + CustomsFee + " EGP");
            Console.WriteLine("Estimated Cost : " + EstimatedCost + " EGP");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs report for {TrackingCode}: standard processing.");
        }
    }

    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string destinationCountry, decimal customsFee)
            : base(trackingCode, destinationCountry, customsFee) { }

        public PriorityInternationalShipment(string trackingCode, string description, double weight,
                                              decimal deliveryFee, DeliveryAddress destination,
                                              string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee) { }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority customs report for {TrackingCode}: expedited clearance requested.");
        }
    }

    public sealed class CompletedShipment : Shipment
    {
        public DateTime CompletedOn { get; set; }

        public CompletedShipment(string trackingCode, DateTime completedOn) : base(trackingCode)
        {
            CompletedOn = completedOn;
        }

        public CompletedShipment(string trackingCode, string description, double weight,
                                  decimal deliveryFee, DeliveryAddress destination, DateTime completedOn)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CompletedOn = completedOn;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine("--------------------------------------------");
            base.PrintShipment();
            Console.WriteLine("Completed On : " + CompletedOn.ToShortDateString());
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }

    public class DeliveryCenter
    {
        private Shipment[] _shipments;

        public Driver Driver { get; set; }

        public DeliveryCenter(int capacity)
        {
            _shipments = new Shipment[capacity];
        }

        public Shipment this[int index]
        {
            get
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                    return _shipments[index];
                return null;
            }
            set
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                    _shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (_shipments == null) return null;
                foreach (var shipment in _shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                        return shipment;
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (_shipments == null) return false;

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false; 
        }

        public bool RemoveShipment(string trackingCode)
        {
            if (_shipments == null) return false;

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false; 
        }
        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            if (Driver != null)
                Console.WriteLine("Driver : " + Driver.FullName);

            foreach (var shipment in _shipments)
            {
                if (shipment == null) continue;
                Console.WriteLine("--------------------------------------------");
                shipment.PrintShipment();
            }
            Console.WriteLine("==========================================");
        }
    }

    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment == null) return;

            shipment.PrintShipment();
            Console.WriteLine(shipment.GetType().Name + " Printed Successfully.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Driver driver = new Driver("D001", "Ahmed Mohamed", "0100 000 0000");

           
            DeliveryCenter center = new DeliveryCenter(10);

           
            center.Driver = driver;

          
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir", 15);
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, addr1);

            
            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Haram", 22);
            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr2, 30);

           
            DeliveryAddress addr3 = new DeliveryAddress("Alexandria", "Corniche", 5);
            InternationalShipment international =
                new InternationalShipment("SH003", "Television", 8, 120, addr3, "Germany", 100);

            
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            center.PrintAllShipments();

           
            Console.WriteLine("Printing Using DeliveryHelper...");
            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("==========================================");

           
            Console.WriteLine("Updating Weight...");
            Console.WriteLine("Original Weight : " + standard.Weight + " KG");
            standard.UpdateWeight(5);
            Console.WriteLine("Updated Weight : " + standard.Weight + " KG");
            standard.UpdateWeight(5, 0.5);
            Console.WriteLine("Updated Weight After Packing : " + standard.Weight + " KG");
            Console.WriteLine("==========================================");

           
            Console.WriteLine("Printing Using Shipment[]...");
            Shipment[] mixedShipments = new Shipment[] { standard, express, international };
            foreach (Shipment s in mixedShipments)
            {
               
                Console.WriteLine(s.GetType().Name + "...");
            }
            Console.WriteLine("==========================================");

           
            CompletedShipment completed = new CompletedShipment("SH004", "Books", 1, 40, addr1, DateTime.Now);
            completed.PrintShipment();
           
            PriorityInternationalShipment priority =
                new PriorityInternationalShipment("SH005", "France", 80);
            priority.GenerateCustomsReport(); 
            // public class UltraPriorityShipment : PriorityInternationalShipment
            // {
            //     public override void GenerateCustomsReport() { } // compile error
            // }
        }

    }
}
