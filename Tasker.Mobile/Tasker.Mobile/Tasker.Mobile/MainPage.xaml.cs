using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Mobile.Helpers;
using Tasker.Mobile.ViewModels;
using Xamarin.Forms;

namespace Tasker.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var vm = (WorkspaceViewModel)BindingContext;

            ((MainPageHelper)(vm.MainPageHelper))?.InvokeWindowLoaded();
        }
    }
}
