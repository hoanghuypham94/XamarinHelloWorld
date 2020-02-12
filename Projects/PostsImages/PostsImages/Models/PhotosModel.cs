using System;

using Xamarin.Forms;

namespace PostsImages.Models
{
    public class PhotosModel : ContentPage
    {
        public PhotosModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

