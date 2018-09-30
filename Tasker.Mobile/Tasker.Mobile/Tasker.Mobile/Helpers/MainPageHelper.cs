using System;
using System.Collections.Generic;
using System.Text;
using Tasker.Mobile.UI.Pub.Helpers;

namespace Tasker.Mobile.Helpers
{
    public class MainPageHelper : IMainPageHelper
    {
        public event Action WindowLoaded;

        public void InvokeWindowLoaded()
        {
            WindowLoaded?.Invoke();
        }
    }
}