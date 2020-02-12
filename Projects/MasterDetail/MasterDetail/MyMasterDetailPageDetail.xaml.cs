using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageDetail : ContentPage
    {
        public MyMasterDetailPageDetail()
        {
            InitializeComponent();
             
        }

        private void Button_NextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new D());
        }
    }
}
