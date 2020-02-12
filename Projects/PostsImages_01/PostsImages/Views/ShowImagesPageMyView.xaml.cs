using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using PostsImages.Models;
using PostsImages.Services;
using PostsImages.ViewModels;
using Prism.AppModel;
using Prism.Navigation;
using Refit;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Essentials;
using Device = Xamarin.Forms.Device;


namespace PostsImages.Views
{
    
    public partial class ShowImagesPageMyView : ContentPage
    {
        //public ShowImagesPageMyViewModel ViewModel
        //{
        //    get { return BindingContext as ShowImagesPageMyViewModel; }
        //}
        public ShowImagesPageMyView()
        { 
            InitializeComponent();
            //Device.StartTimer(TimeSpan.FromSeconds(0), () =>
            //{
            //    collectionListview.ItemsSource = ViewModel.CollectionInfo;
            //    return true;
            //});
        }
    }
}
