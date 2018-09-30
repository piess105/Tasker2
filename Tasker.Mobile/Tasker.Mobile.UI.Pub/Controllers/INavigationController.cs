using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.ViewModels;

namespace Tasker.Mobile.UI.Pub.Controllers
{
    public interface INavigationController
    {
        INavigationViewModel ViewModel { get; }
    }
}
