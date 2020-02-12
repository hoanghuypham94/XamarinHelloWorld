using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OurFirstPrismSample.Model;
using Xamarin.Forms;

namespace OurFirstPrismSample.View
{
    public partial class MyViewInformation : ContentPage
    {


        public MyViewInformation()
        {
        }

        public MyViewInformation(string Titles, string Descriptions)
        {
            InitializeComponent();

            MyTitles.Text = Titles;
            MyDescriptions.Text = Descriptions;
        }

        
    }
}
