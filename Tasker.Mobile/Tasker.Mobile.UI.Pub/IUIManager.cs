using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile.UI.Pub
{
    public interface IUIManager<TPage>
        where TPage : class
    {
        TPage OpenMainWindow(IWorkspaceViewModel viewModel);
            
    }
}
