using IAB330Bloomboard.Models;
using IAB330Bloomboard.Views;
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
        TextInfo userName = new TextInfo(" ", DateTime.Now, "Welcome Sri");


        public string userNameText
        {
            get => userName.Text;

        }

        public string userNameTitle
        {
            get => userName.Title;

        }

        TextInfo unitTitle = new TextInfo("IAB330", DateTime.Now, "");


        public string unitTitleText
        {
            get => unitTitle.Text;

        }

        public string unitTitleTitle
        {
            get => unitTitle.Title;

        }

        TextInfo unitInfo = new TextInfo("Welcome to Semester 2, 2020 and the IAB330 - Mobile Application Development unit!", DateTime.Now, "Mobile Application Development");


        public string unitInfoText
        {
            get => unitInfo.Text;

        }

        public string unitInfoTitle
        {
            get => unitInfo.Title;

        }

        TextInfo messageInfo = new TextInfo("IAB330 (workshop) is commencing in two hours at GP VIRTOLT10 from 3pm-5pm", DateTime.Now, "Upcoming class");


        public string messageInfoText
        {
            get => messageInfo.Text;

        }

        public string messageInfoTitle
        {
            get => messageInfo.Title;

        }
    }
}
