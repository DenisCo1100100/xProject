using System.Collections.Generic;
using System.Windows;
using Backend;
using Frontend.View.AllWindows;
using Frontend.ViewModel.AuthorizationRegistrationWindow;
using Frontend.ViewModel.Core;

namespace Frontend
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			ConnectionHandler.Connection();

			new AuthorizationRegistrationWindow
			{
				DataContext = RootViewModel.GetInstance()
			}.Show();
		}
	}
}