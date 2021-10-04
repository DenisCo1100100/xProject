using System.ComponentModel;
using System.Diagnostics;
using UserApi;

namespace Backend.Model.Client
{
	public class AuthorizationModel : INotifyPropertyChanged
	{
		private bool _isAuth;
		public bool IsAuth
		{
			get { return _isAuth; }
			set 
			{
				_isAuth = value;
				OnPropertyChanged("IsAuth");
			}
		}

		private User _user;
		public User User
		{
			get { return _user; }
			set
			{
				_user = value;
				OnPropertyChanged("User");
			}
		}

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

		public void Execute(string login, string password)
		{
			var client = new UserApi.Authorization.AuthorizationClient(ConnectionHandler.Channel);

			var temp = new AuthorizationDataRequest
			{
				Login = login,
				Password = password
			};

			var reply = client.LogIn(temp);

			IsAuth = reply.IsAuth;
			Message = reply.Msg.Message;
			User = reply.User;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				Trace.WriteLine($"=========>{IsAuth}<=========");
			}
		}
	}
}