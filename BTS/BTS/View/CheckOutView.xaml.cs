using BTS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckOutView : ContentPage
	{

        BusController busController = new BusController();
        ScheduleController scheduleController = new ScheduleController();
        BillController billController = new BillController();

		public CheckOutView ()
		{
			InitializeComponent ();

            BillController.SetTotalPrice(BillController.GetSeatCount(), BusController.GetPrice());

            lblBusPrice.Text = BusController.GetPrice().ToString();
            lblBusType.Text = BusController.GetBusType();
            lblDateSchedule.Text = ScheduleController.GetDate().ToString("dd-MM-yyy");
            lblTimeSchedule.Text = ScheduleController.GetTime();
            lblNumberSeats.Text = BillController.GetSeatCount().ToString();
            lblSeatNumbers.Text = BillController.GetSeatNumbers();
            lblTotalPrice.Text = BillController.GetTotalPrice().ToString();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        }
    }
}