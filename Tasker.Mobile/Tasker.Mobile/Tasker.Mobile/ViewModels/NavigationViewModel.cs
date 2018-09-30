using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tasker.Mobile.UI.Pub.ViewModels;
using Xamarin.Forms;

namespace Tasker.Mobile.ViewModels
{
    public class NavigationViewModel : BindableBase, INavigationViewModel
    {
        public Action LeftClicked { get; set; }
        public Action RightClicked { get; set; }
        public Action DateChanged { get; set; }



        public NavigationViewModel()
        {
            PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == "Date")
                {
                    DateChanged.Invoke();
                }
            };
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;

            set
            {
                SetProperty(ref _date, value);
            }
        }

        private ICommand _onLeftClickedCommand;
        public ICommand OnLeftClickedCommand => _onLeftClickedCommand ?? new Command(LeftClicked);

        private ICommand _onRightClickedCommand;
        public ICommand OnRightClickedCommand => _onRightClickedCommand ?? new Command(RightClicked);
    }
}
