using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurFirstPrismSample.Services;
using OurFirstPrismSample.Model;
using Refit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OurFirstPrismSample.View
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class APIMyTabbedPage : TabbedPage
    {
        public Xamarin.Forms.ImageSource ImageLink { get; set; }
        ViewModel.MainPageViewModel _viewModel = new ViewModel.MainPageViewModel();
        public APIMyTabbedPage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel;

        }
        
        

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.GetDataCommand.Execute(null);
            _viewModel.GetTimeLineDataCommand.Execute(null);
            await CallApi();
            
        }

        async Task CallApi()
        {
            var apiResponse = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
            var makeUps = await apiResponse.GetMakeUps("maybelline");
            
            MakeUpList.ItemsSource = makeUps;
        }

        

        public ImageSource ButtonImage
        {
            
            get { return ImageSource.FromFile("https://d3t32hsnjxo7q6.cloudfront.net/i/991799d3e70b8856686979f8ff6dcfe0_ra,w158,h184_pa,w158,h184.png"); }
        }


    }
}
