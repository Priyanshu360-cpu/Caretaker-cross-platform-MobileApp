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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private async void Sign_Up(object sender, EventArgs e)
        {
            if (UserNameEntry.Text != "" & PassEntry.Text != "" & EmailEntry.Text != "" & PhoneEntry.Text != "" & CPassEntry.Text!="")
            {
                if (PassEntry.Text == CPassEntry.Text)
                {
                    int parse;
                    bool isNumber = int.TryParse(PhoneEntry.Text, out parse);
                    if (isNumber == true)
                    {
                        if (EmailEntry.Text.Contains("@"))
                        {
                            await Navigation.PushAsync(new Page1(UserNameEntry.Text));
                            await DisplayAlert("Success", "Welcome to CareTaker", "OK").ConfigureAwait(false);
                        }
                        else
                        {
                            await DisplayAlert("Invalid Email","Enter Correct Email Address","Ok").ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        await DisplayAlert("Wrong Number", "Enter Correct Number", "OK").ConfigureAwait(false);
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Password Didnt Match", "ok").ConfigureAwait(false);
                }
            }
            else
            {
                await DisplayAlert("Invalid Credentials", "Fill up the all the column", "Ok").ConfigureAwait(false);
            }
        }
    }
}