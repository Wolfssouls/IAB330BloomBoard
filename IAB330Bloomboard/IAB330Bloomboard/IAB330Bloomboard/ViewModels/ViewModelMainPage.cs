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

        ICommand TapCommand;
        public void TapViewModel()
        {
            // configure the TapCommand with a method
            TapCommand = new Command(async() =>
            {
              await  Application.Current.MainPage.Navigation.PushAsync(new Views.Page1());
            });
        }
    }
}
