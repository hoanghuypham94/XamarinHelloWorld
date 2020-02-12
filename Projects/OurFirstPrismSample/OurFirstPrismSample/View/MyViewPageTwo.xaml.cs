

using OurFirstPrismSample.Model;
using OurFirstPrismSample.ViewModel;
using Xamarin.Forms;

namespace OurFirstPrismSample.View
{
    public partial class MyViewPageTwo : ContentPage
    {

        public MyViewPageTwo()
        {
            InitializeComponent();
            //BindingContext = new MyViewPageTwo();
        }

        public PageTwoViewModel ViewModel
        {
            get { return BindingContext as PageTwoViewModel; }
        }


        
    }
}
