using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caretaker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(String UserNameEntry)
        {
            InitializeComponent();
            AppUserName.Text = "Hello There " + UserNameEntry+"!";
        }
        private async void SearchPro(object sender, EventArgs e)
        {
            await DisplayAlert("Pop up", "Signal recieved", "OK").ConfigureAwait(false);
        }
       private async void MonitorPro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new monitor());
            await DisplayAlert("Pop up", "Welcome to Monitor Check Page", "OK").ConfigureAwait(false);
        
    }
        private async void DoctorPro(object sender, EventArgs e)
        {
            await DisplayAlert("Pop up", "Doctor Template Here", "Ok").ConfigureAwait(false);
        }
        private async void MedsPro(object sender,EventArgs e)
        {
            await DisplayAlert("Pop up", "Medicine info Page", "Ok").ConfigureAwait(false);
        }
        private async void PremiumPro(object sender,EventArgs e)
        {
            await DisplayAlert("Pop Up", "Premium Feature", "Ok").ConfigureAwait(false);
        }

        }
}