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

        Heading heading = new Heading("Grades", "#042f66");
        public string headingTitle
        {
            get => heading.Title;
        }

        public string headingColour
        {
            get => heading.Colour;
        }

        public string gradeInfoTitle
        {
            get => gradeInfo.Title;

        }
        public string gradeInfoText
        {
            get => gradeInfo.Text;

        }
        Heading PageUnit = new Heading("IAB 330", "#042f66");

        public string PageUniTitle
        {
            get => PageUnit.Title;

        }
        public string PageUnitColour
        {
            get => PageUnit.Colour;

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
