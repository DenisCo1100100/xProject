namespace Backend.Model.Console
{
	public class ConsoleModel : ObservableObject
	{
		private string _message;
		public string Message 
		{
			get { return _message; }
			set
			{ 
				_message = value;
				OnPropertyChanged("Message");
			}
		}
	}
}
