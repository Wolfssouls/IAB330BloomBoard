using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IAB330Bloomboard.ViewModels
{
    class ViewModelMainPage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command NavigateUnits { get; }
        public Command NavigateAnnouncements { get; }


        public ViewModelMainPage()
        {
            NavigateUnits = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.Page1());
            });

            NavigateAnnouncements = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.AnnouncementPage());
            });

        }

    }
}
