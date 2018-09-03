using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BTS.Controller;

namespace BTS.View
{
	public partial class SelectBusView : ContentPage
	{
        public SelectBusController busController;
        bool valid;
		public SelectBusView()
		{
			InitializeComponent();
            busController = new SelectBusController();
        }
        public void OnTapGestureRecognizerTapped(object sender,EventArgs args)
        {
            valid = busController.CheckDetails(typePicker.SelectedIndex,timePicker.SelectedIndex);
            if (valid)
            {
                valid = busController.CheckTime(datePicker.Date, DateTime.Parse(timePicker.SelectedItem.ToString()));
                if (valid)
                {
                    BusController.SetBusType(typePicker.SelectedItem.ToString());
                    BusController.SetPrice(BusController.GetBusType());
                    BusController.SetSeatCapacity(BusController.GetBusType());

                    ScheduleController.SetDate(datePicker.Date);
                    ScheduleController.SetTime(timePicker.SelectedItem.ToString());
                    Navigation.PushAsync(new SelectSeatView());
                }
                
                else
                    DisplayAlert("Invalid", "Trip has already departed. Please pick other time.", "OK");
            }
            else
                DisplayAlert("Incomplete Details", "Please complete all the data", "OK");
        }

    }
}
