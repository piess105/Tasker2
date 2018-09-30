using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.Helpers;
using Tasker.Mobile.UI.Pub;
using Tasker.Mobile.UI.Pub.Helpers;
using Tasker.Mobile.UI.Pub.ViewModels;
using Tasker.Mobile.ViewModels;
using Unity;

namespace Tasker.Mobile.Infrastructure
{
    public static class Installer
    {
        public static void Install(IUnityContainer container)
        {
            container.RegisterType(typeof(IUIManager<MainPage>), typeof(UIManager));

            container.RegisterSingleton<IMainPageHelper, MainPageHelper>();

            container.RegisterType<INavigationViewModel, NavigationViewModel>();
            container.RegisterType<IWorkspaceViewModel, WorkspaceViewModel>();
        }
    }
}
