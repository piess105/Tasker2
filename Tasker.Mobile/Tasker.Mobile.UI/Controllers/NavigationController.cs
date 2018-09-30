using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.Controllers;
using Tasker.Mobile.UI.Pub.Helpers;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile.UI.Controllers
{
    public class NavigationController : ControllerBase<INavigationViewModel>, INavigationController
    {
        public IMainPageHelper MainPageHelper { get; }

        public NavigationController(
            IMainPageHelper mainPageHelper,
            INavigationViewModel viewModel) : base(viewModel)
        {
            ViewModel.LeftClicked = OnLeftClicked;
            ViewModel.RightClicked = OnRightClicked;
            ViewModel.DateChanged = OnDateChanged;
            MainPageHelper = mainPageHelper;

            MainPageHelper.WindowLoaded += MainPageHelper_WindowLoaded;
        }

        private void OnDateChanged()
        {
           
        }

        private void MainPageHelper_WindowLoaded()
        {
            ViewModel.Date = DateTime.Now;
        }

        private void OnRightClicked()
        {
            ViewModel.Date = ViewModel.Date.AddDays(1);
        }

        private void OnLeftClicked()
        {
            ViewModel.Date = ViewModel.Date.AddDays(-1);
        }
    }
}
