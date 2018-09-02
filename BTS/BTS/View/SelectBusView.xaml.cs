using BTS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTS.View
{
	public partial class SelectBusView : ContentPage
	{
        BusController busController = new BusController();
        ScheduleController scheduleController = new ScheduleController();
		public SelectBusView()
		{
			InitializeComponent();
		}
        public void OnTapGestureRecognizerTapped(object sender,EventArgs args)
        {
            BusController.SetBusType(pickerBusType.SelectedItem.ToString());
            BusController.SetPrice(BusController.GetBusType());
            BusController.SetSeatCapacity(BusController.GetBusType());

            ScheduleController.SetDate(dpDate.Date);
            ScheduleController.SetTime(pickerTime.SelectedItem.ToString());
            
            Navigation.PushAsync(new SelectSeatView());
        }

    }
}
