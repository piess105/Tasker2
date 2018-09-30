using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.Helpers;
using Tasker.Mobile.UI.Pub.Helpers;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile.ViewModels
{
    public class WorkspaceViewModel : BindableBase, IWorkspaceViewModel
    {
        public INavigationViewModel NavigationViewModel { get; set; }

        public IMainPageHelper MainPageHelper { get; set; }
    }
}
