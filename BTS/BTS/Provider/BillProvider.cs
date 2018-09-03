using BTS.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BTS
{
    public class BillProvider
    {
        
        // Bill Setters
        public static void SetTotalSeats()
        {
            Bill.TotalSeats = 46;
        }
        public static void SetPenalty(bool penalty)
        {
            if (penalty)
            {
                Bill.Penalty = 50.00;
            }
                
            else
                Bill.Penalty = 0.00;
        }

        public static void SetPenaltyStatus(bool status)
        {
            if (status)
                Bill.PenaltyStatus = true;
            else
                Bill.PenaltyStatus = false;
        }

        public static void SetSeatCount(bool value)
        {
            if (value)
                Bill.Seats++;
            else
                Bill.Seats--;
        }
        public static void SetTotalPrice(int seat, double price, double penalty)
        {
            Bill.TotalPrice = (seat * price) + penalty;
        }
        public static void SetSeatNumbersOn(string num)
        {
            Bill.SeatNames += num + " ";
        }
        public static void SetSeatNumbersOff()
        {
            Bill.SeatNames = Bill.SeatNames.Remove(Bill.SeatNames.Length - 3);
        }

        // Bill Getters
        public static double GetPenalty()
        {
            return Bill.Penalty;
        }

        public static bool GetPenaltyStatus()
        {
            return Bill.PenaltyStatus; 
        }

        public static int GetSeatCount()
        {
            return Bill.Seats;
        }
        public static int GetTotalSeats()
        {
            return Bill.TotalSeats;
        }
        public static double GetTotalPrice()
        {
            return Bill.TotalPrice;
        }
        public static string GetSeatNumbers()
        {
            return Bill.SeatNames;
        }
    }
}
