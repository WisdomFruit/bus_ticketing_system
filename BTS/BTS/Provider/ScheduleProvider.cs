using BTS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTS
{
    public class ScheduleProvider
    {

        // Schedule Setters
        public static void SetDate(DateTime date)
        {
            Schedule.Date = date;
        }
        public static void SetTime(string time)
        {
            Schedule.Time = time;
        }

        // Schedule Getters
        public static string GetTime()
        {
            return Schedule.Time;
        }
        public static DateTime GetDate()
        {
            return Schedule.Date;
        }
    }
}
