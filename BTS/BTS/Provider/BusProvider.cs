using BTS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTS
{
    public class BusProvider
    {
        // Bus Setters
        public static void SetBusType(string type)
        {
            Bus.Type = type;
        }
        public static void SetPrice(string type)
        {
            if (type.Equals("Ordinary Bus"))
            {
                Bus.Price = 100.00;
            }

            else if (type.Equals("Airconditioned Bus"))
            {
                Bus.Price = 200.00;
            }

            else if (type.Equals("Deluxe Bus"))
            {
                Bus.Price = 300.00;
            }
            else
            {
                Bus.Price = 0.00;
            }
        }
        public static void SetSeatCapacity(string type)
        {
            if (type.Equals("Ordinary Bus"))
            {
                Bus.SeatCapacity = 46;
            }

            else if (type.Equals("Airconditioned Bus"))
            {
                Bus.SeatCapacity = 46;
            }

            else if (type.Equals("Deluxe Bus"))
            {
                Bus.SeatCapacity = 46;
            }
            else
            {
                Bus.SeatCapacity = 0;
            }
        }

        // Bus Getters
        public static string GetBusType()
        {
            return Bus.Type;
        }
        public static int GetSeatCapacity()
        {
            return Bus.SeatCapacity;
        }
        public static double GetPrice()
        {
            return Bus.Price;
        }

        
    }
}
