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
    class ViewModelGrades : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command NavigateUnits { get; }
        public Command NavigateAnnouncements { get; }


        public ViewModelGrades()
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

        TextInfo gradeInfo = new TextInfo("Well done, you have gotten a very good grade i am very impressed, you are very smart Sri!", DateTime.Now, "More Grade Information");


        public string gradeInfoText
        {
            get => gradeInfo.Text;

        }

        public string gradeInfoTitle
        {
            get => gradeInfo.Title;

        }

        TextInfo pageHeading = new TextInfo(" ", DateTime.Now, "Results for Sri!");


        public string pageHeadingText
        {
            get => pageHeading.Text;

        }

        public string pageHeadingTitle
        {
            get => pageHeading.Title;

        }

        TextInfo unitName = new TextInfo(" ", DateTime.Now, "  IAB 330");


        public string unitNameText
        {
            get => unitName.Text;

        }

        public string unitNameTitle
        {
            get => unitName.Title;

        }

    }
}
