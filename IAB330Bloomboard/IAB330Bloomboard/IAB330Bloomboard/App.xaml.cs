using IAB330Bloomboard.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Bloomboard
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new Views.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#042f66")
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }



    }
}
