using IAB330Bloomboard.Models;
using IAB330Bloomboard.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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
        public Command navigateGrades { get; }

        public ViewModelUnits()
        {
            Navigate = new Command(async () =>
           {
               await Application.Current.MainPage.Navigation.PushAsync(new AnnouncementPage());
           });

            navigateGrades = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Grades());
            });




        }

        TextInfo Announcments = new TextInfo("Dear IAB330 students, Welcome to Week 2!&#10;I hope you've all had a good weekend.", DateTime.Now, "Announcments");
        

        public string AnnouncmentsText
        {
            get => Announcments.Text;

        }

        public string AnnouncmentsTitle
        {
            get => Announcments.Title;

        }

        TextInfo Weekly = new TextInfo("Please watch the Lecture 2 video recordings.&#10;Then take part in the collective SWOT analysis Prepare for your first Tutorial&#10;(Optional) Review the lecture slides ", DateTime.Now, "Weekly");


        public string WeeklyText
        {
            get => Weekly.Text;

        }

        public string WeeklyTitle
        {
            get => Weekly.Title;

        }

        TextInfo assessments = new TextInfo("This assessment task requires you to investigate a problem space and create a report that explains the need for and design of a mobile application.", DateTime.Now, "Assessments");


        public string AssessmentsText
        {
            get => assessments.Text;

        }

        public string AssessmentsTitle
        {
            get => assessments.Title;

        }






    }

    
} 
