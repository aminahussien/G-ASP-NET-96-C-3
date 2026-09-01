using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2C_.Classes
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private string centerName;

        public string CenterName
        {
            set
            {
                centerName = value;
            }

        }



        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                    return default;
                return shipments[index];
            }
            set
            {
                if (shipments == null)
                    shipments = new Shipment[10];

                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }

        }

        public Shipment this[string code]
        {
            get
            {
                if (shipments != null)
                    foreach (var ship in shipments)
                    {
                        if (ship.TrackingCode == code)
                            return ship;
                    }
                return default;
            }
        }

        public bool AddShipment(Shipment ship)
        {
            if (shipments == null)
                shipments = new Shipment[10];
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = ship;
                    return true;
                }

            }
            return false;
        }

        public bool RemoveShipment(string code)
        {


            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode ==code )
                {
                    shipments[i] = default;
                    return true;
                }
               
            }
            return false;

        }

        public void PrintAllShipments()
        {
            if (shipments!=null)
            {
                for(int i =0;i<shipments.Length;i++)
                {

                    if (shipments[i] != null)
                        shipments[i].PrintShipment();
                    else
                        Console.WriteLine("shipment not found !");
                    Console.WriteLine();
                }
            }
        }



    }
}
