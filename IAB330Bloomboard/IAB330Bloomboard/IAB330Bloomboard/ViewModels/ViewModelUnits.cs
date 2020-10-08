using IAB330Bloomboard.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IAB330Bloomboard.ViewModels
{
    class ViewModelUnits : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command Navigate { get; }

        public ViewModelUnits()
        {
            Navigate = new Command( async () =>
            {
              await  Application.Current.MainPage.Navigation.PushAsync(new AnnouncementPage());
            });
        }
       
        
    }

    
} 
