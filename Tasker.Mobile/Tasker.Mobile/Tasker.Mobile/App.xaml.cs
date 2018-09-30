using DLToolkit.Forms.Controls;
using System;
using Tasker.Mobile.Infrastructure;
using Tasker.Mobile.UI;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Tasker.Mobile
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            FlowListView.Init();
        }

		protected override void OnStart ()
		{
            var container = new UnityContainer();
            Installer.Install(container);
            Tasker.Mobile.UI.Infrastructure.Installer.Install(container);

            var appMgr = container.Resolve<AppManager<MainPage>>();

            MainPage = appMgr.Start();
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
