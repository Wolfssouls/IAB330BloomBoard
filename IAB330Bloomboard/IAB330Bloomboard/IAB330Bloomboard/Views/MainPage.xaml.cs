using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IAB330Bloomboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.Page1());
        }

        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.Page1());
        }
 
          private void TapGestureRecognizer_Announcements(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.AnnouncementPage());
        }
    }
}
