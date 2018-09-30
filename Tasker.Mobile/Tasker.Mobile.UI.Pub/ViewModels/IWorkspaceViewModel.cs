using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.Helpers;

namespace Tasker.Mobile.UI.Pub.ViewModels
{
    public interface IWorkspaceViewModel
    {
        INavigationViewModel NavigationViewModel { get; set; }
        IMainPageHelper MainPageHelper { get; set; }
    }
}
