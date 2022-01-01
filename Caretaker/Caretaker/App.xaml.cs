using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caretaker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected async override void OnStart()
        {
            var progressBar = new ProgressBar
            {
                Progress = .2,
            };
            await progressBar.ProgressTo(.8, 250, Easing.Linear);

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
