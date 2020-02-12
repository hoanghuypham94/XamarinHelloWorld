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
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MyMasterDetailPageMenuItem;
            if (item == null)
                return;
            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            switch (item.Id)
            {
                case 0:
                    Detail = new NavigationPage(new DemoCalculator());
                    IsPresented = false;
                    break;
                case 1:
                    Detail = new NavigationPage(new DemoGrid());
                    IsPresented = false;
                    break;
                case 2:
                    Detail = new NavigationPage(new DemoScrollview());
                    IsPresented = false;
                    break;
                case 3:
                    Detail = new NavigationPage(new Demostackayout());
                    IsPresented = false;
                    break;
                case 4:
                    Detail = new NavigationPage(new DemoAbsoluteLayout());
                    IsPresented = false;
                    break;
                case 6:
                    Detail = new NavigationPage(new MyTabbedPage());
                    IsPresented = false;
                    break;
                case 7:
                    Detail = new NavigationPage(new MyMasterDetailPageDetail());
                    IsPresented = false;
                    break;



            }

            
            MasterPage.ListView.SelectedItem = null;
        }
    }
}
