using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tasker.Mobile.UI.Pub.ViewModels;
using Xamarin.Forms;

namespace Tasker.Mobile.ViewModels
{
    public abstract class LoadableViewModelBase : BindableBase, ILoadableViewModel
    {
        public Action WindowLoaded { get; set; }

        private ICommand _onWindowLoadedCommand;
        public ICommand OnWindowLoadedCommand => _onWindowLoadedCommand ?? new Command(WindowLoaded);
    }
}
