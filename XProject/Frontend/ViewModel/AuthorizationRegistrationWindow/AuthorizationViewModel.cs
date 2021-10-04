using Frontend.ViewModel.Core;
using Backend.Model.Client;
using Frontend_View.ViewModel;
using System;
using HandyControl.Controls;
using System.Diagnostics;

namespace Frontend.ViewModel.AuthorizationRegistrationWindow
{
	public class AuthorizationViewModel : ObservableObjcet, IControlViewModel
	{
		public string Title => "Authorization";


		#region Property

		private string _login;
		public string Login
		{
			get { return _login; }
			set 
			{
				_login = value;
				OnPropertyChanged();
			}
		}

		private string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged();
			}
		}

		private bool _isAuth;
		public bool IsAuth
		{
			get { return _authorizationModel.IsAuth; }
			set 
			{
				_isAuth = value;
				OnPropertyChanged();
			}
		}
		#endregion


		private AuthorizationModel _authorizationModel;
		public AuthorizationViewModel()
		{

			OpenFirstStageReg = new DelegateCommand(o =>
			{
				RootViewModel.GetInstance().CurrentContentVM = new FirstStageRegViewModel();
			});

			LogIn = new DelegateCommand(o =>
			{
				new AuthorizationModel().Execute(Login, Password);

				if (IsAuth)
				{
					Trace.WriteLine("Авторизовался.Открываю мейн окно");
				}
				else
				{
					Trace.WriteLine("Не авторизовался");
				}
			});

			_authorizationModel = new AuthorizationModel();
		}

		/*COMMAND*/
		public DelegateCommand OpenFirstStageReg { get; private set; }
		public DelegateCommand LogIn { get; private set; }
	}
}