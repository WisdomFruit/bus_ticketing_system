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
    public partial class SelectSeatView : ContentPage
    {
        public SelectSeatView()
        {
            InitializeComponent();
            int seat = 1;
            for (int row = 1; row < 12; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if ((row != 6 || (col != 3 && col != 4)) && (col != 2 || row == 11))
                    {
                        Button button = new Button();
                        button.Text = seat.ToString();
                        button.FontSize = 10;
                        button.TextColor = Color.White;
                        button.Clicked += ButtonClicked;
                        button.BackgroundColor = Color.FromHex("#C8E6C9");
                        Grid.SetRow(button, row);
                        Grid.SetColumn(button, col);
                        SeatGrid.Children.Add(button);
                        seat++;
                    }
                }
            }
        }
        public void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackgroundColor == Color.FromHex("#C8E6C9"))
                button.BackgroundColor = Color.FromHex("#4CAF50");
            else
                button.BackgroundColor = Color.FromHex("#C8E6C9");
        }
        public void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CheckOutView());
        }
    }
}