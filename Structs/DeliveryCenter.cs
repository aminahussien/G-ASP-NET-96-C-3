using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2C_.Structs
{
    public struct DeliveryCenter
    {
       private Shipment[] shipments;
      


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
                    foreach(var ship in shipments)
                    {
                        if (ship.TrackingCode == code)
                            return ship;
                    }
                return default;
            }
        }

        public bool AddShipment(Shipment ship)
        {
            if (shipments==null)
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
    }
}
