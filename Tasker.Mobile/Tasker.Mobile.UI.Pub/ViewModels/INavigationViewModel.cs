using System;
using System.Collections.Generic;
using System.Text;

namespace Tasker.Mobile.UI.Pub.ViewModels
{
    public interface INavigationViewModel
    {
        Action LeftClicked { get; set; }
        Action RightClicked { get; set; }
        Action DateChanged { get; set; }

        DateTime Date { get; set; }
    }
}
