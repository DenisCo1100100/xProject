using System.Diagnostics;
using Backend.Model.Client;
using Frontend.ViewModel.Core;
using UserApi;

namespace Frontend.ViewModel.AuthorizationRegistrationWindow
{
	public class SecondStageRegViewModel : ObservableObjcet
	{
		#region Property
		private string _login;
		public string Login
		{
			get { return _login; }
			set
			{
				_login = value;
				OnPropertyChanged("Login");
			}
		}

		private string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged("Password");
			}
		}
		#endregion

		public SecondStageRegViewModel(UserApi.User user)
		{
			RegisterNewUser = new DelegateCommand(o =>
			{
				user.Login = Login;
				user.Password = Password;

				var reg = new RegistrationModel();
				reg.Execute(user);

				if (reg.IsRegister)
				{
					Trace.WriteLine("Зарегал. Все ок");
				}
				else
				{
					Trace.WriteLine("Не зарегал. Все не ок");
				}

				RootViewModel.GetInstance().CurrentContentVM = new AuthorizationViewModel();
			});

			OpenAuthorization = new DelegateCommand(o =>
			{
				RootViewModel.GetInstance().CurrentContentVM = new AuthorizationViewModel();
			});
		}

		/*COMMAND*/

		public DelegateCommand RegisterNewUser { get; private set; }
		public DelegateCommand OpenAuthorization { get; private set; }
	}
}
