using Backend.Model.Console;
using Frontend.ViewModel.Core;

namespace Frontend_View.ViewModel
{
	public class ConsoleViewModel : ObservableObjcet
	{
		private ConsoleModel _consoleMessage;
		public ConsoleModel ConsoleMessage 
		{
			get { return _consoleMessage; }
			set
			{
				_consoleMessage = value;
				OnPropertyChanged();
			}
		}

		private ConsoleViewModel() { }

		private static ConsoleModel _instance;

		public static ConsoleModel GetInstance()
		{
			if (_instance == null)
			{
				_instance = new ConsoleModel();
			}

			return _instance;
		}
	}
}
