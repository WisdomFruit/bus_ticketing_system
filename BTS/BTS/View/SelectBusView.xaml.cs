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
		public SelectBusView()
		{
			InitializeComponent();
		}
        public void OnTapGestureRecognizerTapped(object sender,EventArgs args)
        {
            Navigation.PushAsync(new SelectSeatView());
        }

    }
}
