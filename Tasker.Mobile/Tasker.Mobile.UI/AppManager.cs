using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub;
using Tasker.Mobile.UI.Pub.Controllers;
using Tasker.Mobile.UI.Pub.Helpers;

namespace Tasker.Mobile.UI
{
    public class AppManager<TPage>
        where TPage : class
    {
        public AppManager(
            IMainPageHelper mainPageHelper,
            INavigationController navigationController,
            IWorkspaceController workspaceController,
            IUIManager<TPage> uIManager)
        {
            MainPageHelper = mainPageHelper;
            NavigationController = navigationController;
            WorkspaceController = workspaceController;
            UIManager = uIManager;
        }

        private IMainPageHelper MainPageHelper { get; }
        private INavigationController NavigationController { get; }
        private IWorkspaceController WorkspaceController { get; }
        private IUIManager<TPage> UIManager { get; }

        public TPage Start()
        {
            WorkspaceController.ViewModel.NavigationViewModel = NavigationController.ViewModel;
            WorkspaceController.ViewModel.MainPageHelper = MainPageHelper;

            var page = UIManager.OpenMainWindow(WorkspaceController.ViewModel);

            return page;
        }
    }
}
