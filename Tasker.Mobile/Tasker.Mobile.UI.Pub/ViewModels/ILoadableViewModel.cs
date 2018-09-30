using System;
using System.Collections.Generic;
using System.Text;

namespace Tasker.Mobile.UI.Pub.ViewModels
{
    public interface ILoadableViewModel
    {
        Action WindowLoaded { get; set; }
    }
}
