using System.Collections.Generic;
using Backend.Model.Console;
using Frontend.ViewModel.Core;

namespace Frontend.ViewModel.AuthorizationRegistrationWindow
{
	public class RootViewModel : ObservableObjcet
	{
		private RootViewModel() 
		{
			CurrentContentVM = new AuthorizationViewModel();
		}

		private static RootViewModel _instance;

		public static RootViewModel GetInstance()
		{
			if (_instance == null)
			{
				_instance = new RootViewModel();
			}

			return _instance;
		}

		private object _currentContentVM;
		public object CurrentContentVM
		{
			get => _currentContentVM;
			set
			{
				_currentContentVM = value;
				OnPropertyChanged("CurrentContentVM");
			}

		}
	}
}
