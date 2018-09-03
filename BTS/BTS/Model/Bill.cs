using System;
using System.Collections.Generic;
using System.Text;

namespace BTS.Model
{
    public class Bill
    {
        public static int Seats { set; get; }
        public static int TotalSeats { set; get; }
        public static double Penalty { set; get; }
        public static bool PenaltyStatus { set; get; }
        public static double TotalPrice { set; get; }
        public static string SeatNames { set; get; }
    }
}
