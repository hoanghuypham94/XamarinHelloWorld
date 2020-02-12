using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
            
        }

        class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }

            public MyMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
                {
                    new MyMasterDetailPageMenuItem { Id = 0, Title = "Calculator" },
                    new MyMasterDetailPageMenuItem { Id = 1, Title = "GridView" },
                    new MyMasterDetailPageMenuItem { Id = 2, Title = "ScrollView" },
                    new MyMasterDetailPageMenuItem { Id = 3, Title = "StackLayout" },
                    new MyMasterDetailPageMenuItem { Id = 4, Title = "AbsoluteLayout" },
                    new MyMasterDetailPageMenuItem { Id = 5, Title = "RelativeLayout" },
                    new MyMasterDetailPageMenuItem { Id = 6, Title = "Tabbed Page" },
                    new MyMasterDetailPageMenuItem { Id = 7, Title = "Navigation Page" },

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
