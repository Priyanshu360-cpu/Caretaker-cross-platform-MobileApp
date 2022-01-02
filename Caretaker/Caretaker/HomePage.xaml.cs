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
            AppUserName.Text = "Hello There " + UserNameEntry;
        }
        private async void SearchPro(object sender, EventArgs e)
        {
            await DisplayAlert("Pop up", "Signal recieved", "OK").ConfigureAwait(false);
        }
       private async void MonitorPro(object sender, EventArgs e)
        {
            await DisplayAlert("Pop up", "Monitor Page To be Pushed", "OK").ConfigureAwait(false);
        
    }

        }
}