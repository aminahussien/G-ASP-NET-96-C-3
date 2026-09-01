using Assignment2C_.Classes;
using Assignment2C_.Structs;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter();
            center.CenterName = centerName;

            
            Console.WriteLine("\nEnter Standard Shipment Data");
            Console.Write("Tracking Code: ");
            string code1 = Console.ReadLine();
            Console.Write("Description: ");
            string desc1 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());
            DeliveryAddress address1 = ReadAddress();

            StandardShipment standard = new StandardShipment(code1, desc1, weight1, fee1, address1);
            center.AddShipment(standard);

           
            Console.WriteLine("\nEnter Express Shipment Data");
            Console.Write("Tracking Code: ");
            string code2 = Console.ReadLine();
            Console.Write("Description: ");
            string desc2 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());
            DeliveryAddress address2 = ReadAddress();
            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            
            ExpressShipment express = new ExpressShipment(extraFee, code2, desc2, weight2, fee2, address2);
            center.AddShipment(express);

          
            Console.WriteLine("\nEnter International Shipment Data");
            Console.Write("Tracking Code: ");
            string code3 = Console.ReadLine();
            Console.Write("Description: ");
            string desc3 = Console.ReadLine();
            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());
            DeliveryAddress address3 = ReadAddress();
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();
            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            
            InternationalShipment international = new InternationalShipment(
                destinationCountry, customsFee, code3, desc3, weight3, fee3, address3);
            center.AddShipment(international);

            
            Console.WriteLine();
            center.PrintAllShipments();

            
            Console.Write("\nEnter a tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];

            if (found != null)
                Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            else
                Console.WriteLine("Shipment not found.");

          
            Console.Write("\nEnter a tracking code to remove: ");
            string removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode);
            Console.WriteLine(removed ? "Shipment removed successfully." : "Shipment not found.");

            
            Console.WriteLine();
            center.PrintAllShipments();
        }

        static DeliveryAddress ReadAddress()
        {
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Street: ");
            string street = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());

            return new DeliveryAddress(city, street, buildingNumber);
        }
    }
}