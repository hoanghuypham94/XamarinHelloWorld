using System;
using System.Collections.Generic;
using OurFirstPrismSample.Controls;
using Xamarin.Forms;

namespace OurFirstPrismSample.View
{
    public partial class PageThreeMyView : ContentPage
    {
        public PageThreeMyView()
        {
            InitializeComponent();
            AddInitialPhotos();
        }

        public void AddInitialPhotos()
        {
            for (int i = 0; i < 10; i++)
            {
                InsertPhoto();
            }
        }

        private void InsertPhoto()
        {
            var photo = new SwiperControl();
            this.MainGrid.Children.Insert(0, photo);
        }
    }
}
