using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.Controllers;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile.UI.Controllers
{
    public class NavigationController : INavigationController
    {
        public INavigationViewModel ViewModel { get; }

        public NavigationController(INavigationViewModel viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
