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


        }
    }
}