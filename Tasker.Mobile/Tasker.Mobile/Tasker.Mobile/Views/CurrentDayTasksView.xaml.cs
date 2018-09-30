using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CurrentDayTasksView : ContentView
	{
		public CurrentDayTasksView ()
		{
			InitializeComponent ();

            Kowadlo.FlowItemsSource = new List<string> { "DS", "DSDSD", "DS", "DSDSD", "DS", "DSDSD", "DS", "DSDSD" };

        }
	}
}