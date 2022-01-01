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
            AppUserName.Text = "Hello," + UserNameEntry;
        }
    }
}