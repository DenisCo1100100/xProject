using System.ComponentModel;
using UserApi;

namespace Backend.Model.Client
{
	public class RegistrationModel : INotifyPropertyChanged
	{
		private bool _isRegister;
		public bool IsRegister
		{
			get { return _isRegister; }
			set
			{
				_isRegister = value;
				OnPropertyChanged("IsRegister");
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

		public void Execute(User userInp)
		{
			var personData = new PersonalData
			{
				Name = userInp.PersonalData.Name,
				Surname = userInp.PersonalData.Surname,
				Patronymic = userInp.PersonalData.Patronymic,
				Yearsold = userInp.PersonalData.Yearsold
			};

			var userOut = new User
			{
				Login = userInp.Login,
				Password = userInp.Password,
				AccessLvl = userInp.AccessLvl,
				PersonalData = personData
			};

			var temp = new RegistrationDataRequest
			{
				UserRegData = userOut
			};

			var _client = new UserApi.Registration.RegistrationClient(ConnectionHandler.Channel);
			var reply = _client.RegistrationNewUser(temp);

			IsRegister = reply.IsRegister;
			Message = reply.Msg.Message;
			User = reply.User;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
