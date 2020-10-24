using IAB330Bloomboard.Views;
using System;
using IAB330Bloomboard.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IAB330Bloomboard.ViewModels
{
    class ViewModelAnnouncement : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        TextInfo Announcments1 = new TextInfo("Dear IAB330 students, \nWelcome to Week 2! I hope you've all had a good weekend.  ...", DateTime.Now, "Announcement 1- from unit IAB330 \nWeek 2");
        Heading heading = new Heading("Announcement", "#042f66");

        public string headingTitle
        {
            get => heading.Title;
        }

        public string headingColour
        {
            get => heading.Colour;
        }

        public string AnnouncmentsText1
        {
            get => Announcments1.Text;

        }

        public string AnnouncmentsTitle1
        {
            get => Announcments1.Title;


        }
        TextInfo Announcments2 = new TextInfo("Hi everyone, \nWell done with your final exam. &#x0a;For those who have received the 'LATE' ... ", DateTime.Now, "Announcement 2- from unit IAB230 \nLate Assessment");
        public string AnnouncmentsText2
        {
            get => Announcments2.Text;

        }

        public string AnnouncmentsTitle2
        {
            get => Announcments2.Title;


        }

        TextInfo Announcments3 = new TextInfo("Dear students, \nI assume you are all have been in contact with your project supervisor (industry or academic) about their feedback form and the handover. If not and there are any ... ", DateTime.Now, "Announcement 3- from unit IFB399 \nProject Supervisor");
        public string AnnouncmentsText3
        {
            get => Announcments3.Text;

        }

        public string AnnouncmentsTitle3
        {
            get => Announcments3.Title;


        }

        TextInfo Announcments4 = new TextInfo("Announcement 4- from unit IAB204 \n BA Toolkit for Assignment 1 ", DateTime.Now, "Dear Students \n We have uploaded a toolkit for your assignment 1.");
        public string AnnouncmentsText4
        {
            get => Announcments4.Text;

        }

        public string AnnouncmentsTitle4
        {
            get => Announcments4.Title;


        }
    }
}
