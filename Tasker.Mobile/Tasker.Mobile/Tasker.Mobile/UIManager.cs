using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile
{
    public class UIManager : IUIManager<MainPage>
    {
        public MainPage OpenMainWindow(IWorkspaceViewModel viewModel)
        {
            var page = new MainPage { BindingContext = viewModel };

            return page;
        }
    }
}
