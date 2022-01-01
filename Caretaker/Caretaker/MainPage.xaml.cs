using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Caretaker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (UserNameEntry.Text != ""&PassEntry.Text!="")
            {
                await Navigation.PushAsync(new Page1(UserNameEntry.Text));
                await DisplayAlert("Login", "Login Successful", "OK").ConfigureAwait(false);
            }
            else
            {
                await DisplayAlert("Invalid Credentials","Fill up the all the column","Ok").ConfigureAwait(false);
            }
        }

        [Obsolete]
        protected async void Signup_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        [Obsolete]
        protected void Tandc(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://discord.gg/9cKGtRNDqZ"));
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

      
    }
}
