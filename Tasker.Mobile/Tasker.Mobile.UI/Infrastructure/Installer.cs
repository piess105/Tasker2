using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Controllers;
using Tasker.Mobile.UI.Pub;
using Tasker.Mobile.UI.Pub.Controllers;
using Unity;

namespace Tasker.Mobile.UI.Infrastructure
{
    public static class Installer
    {
        public static void Install(IUnityContainer container)
        {
            container.RegisterType(typeof(AppManager<>));
            container.RegisterType<INavigationController, NavigationController>();
            container.RegisterType<IWorkspaceController, WorkspaceController>();
        }
    }
}
