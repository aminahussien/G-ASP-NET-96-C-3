using Assignment2C_.Structs;
namespace Assignment2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            DeliveryAddress delivery = new DeliveryAddress("alex","roushdy",5);
            DeliveryAddress delivery2 = new DeliveryAddress("cairo", "maadi", 7);
            Console.WriteLine( delivery.GetFullAddress());
            Console.WriteLine(delivery2.GetFullAddress());
            delivery2 = delivery;
            Console.WriteLine(delivery.GetFullAddress());
            Console.WriteLine(delivery2.GetFullAddress());

            DeliveryCenter center = new DeliveryCenter();

            for(int i=0; i<3;i++)
            {
                Console.WriteLine( $"enter shipment number{i+1}" );
                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                int weight = int.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, fee, address);
                center.AddShipment(shipment);

            }
            Console.WriteLine(" All Shipments");
            for (int j = 0; j < 3; j++)
            {
                center[j].PrintShipment();
                Console.WriteLine();
            }

            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            if (found.TrackingCode != null)
                Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            else
                Console.WriteLine("Shipment not found.");

        }
    }
}