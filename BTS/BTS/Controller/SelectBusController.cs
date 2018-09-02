using System;
using System.Collections.Generic;
using System.Text;

namespace BTS.Controller
{
    public class SelectBusController
    {
        public bool CheckDetails(int typePickerIndex, int timePickerIndex)
        {
            if (typePickerIndex >= 0 && timePickerIndex >= 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public bool CheckTime(DateTime datePicker, DateTime timePicker)
        {
            if (datePicker == DateTime.Today)
            {
                if (timePicker > DateTime.Now)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
    }
}
