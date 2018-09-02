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
		public CheckOutView ()
		{
			InitializeComponent ();
            dateNow.Text = "Date : " + DateTime.Now.ToString("MMMM dd, yyyy");
            timeNow.Text = "Time : " + DateTime.Now.ToString("hh: mm tt");
        }
        public async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Xamarin.Forms.FileImageSource fileImageSource = (Xamarin.Forms.FileImageSource)checkoutButton.Source;
            string strFileName = fileImageSource.File;
            if (strFileName == "okay_button.png")
            {
                bool choice = await DisplayAlert("Confirm", "Are you sure you want to book this trip?", "OK", "Edit");
                if (choice == true)
                {
                    await DisplayAlert("Trip Booked", "Thank you for using BTS. Have a nice trip!", "OK");
                    NavigationPage.SetHasBackButton(this, false);
                    checkoutButton.Source = "cancel_button.png";
                }
            }
            else
            {
                bool choice = await DisplayAlert("Confirm", "Cancelling trip might cause penalty. Do you want to cancel trip?", "Yes", "No");
                if (choice == true)
                {
                    await DisplayAlert("Trip Canceled", "Penalty will be charged on your next book.", "OK");
                    NavigationPage.SetHasBackButton(this, true);
                    await Navigation.PushAsync(new SelectBusView());
                    checkoutButton.Source = "okay_button.png";
                }
            }
            
                
        }
    }
}