using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace OurFirstPrismSample.View
{
    public partial class CustomMasterDetailPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public CustomMasterDetailPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get { return false; }
        }
    }
}
