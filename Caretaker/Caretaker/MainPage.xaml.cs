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
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Successful", "OK");
        }

        [Obsolete]
        protected void Signup_Page(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://discord.gg/9cKGtRNDqZ"));
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
