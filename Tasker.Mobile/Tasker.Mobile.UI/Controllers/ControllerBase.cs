using System;
using System.Collections.Generic;
using System.Text;

namespace Tasker.Mobile.UI.Controllers
{
    public abstract class ControllerBase<TViewModel>       
    {
        public TViewModel ViewModel { get; }

        public ControllerBase(TViewModel viewModel)
        {
            ViewModel = viewModel;
        }        
    }
}
