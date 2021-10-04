using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.UserData
{
	public class User
	{
		public int Id { get; private set; }
		public string Login { get; private set; }
		public string Password { get; private set; }
		public UserApi.User.Types.AccessLvl AccessLevele { get; private set; }
		public PersonalData PersonData { get; private set; }

		public User(string login, string password, UserApi.User.Types.AccessLvl accessLvl, PersonalData personalData) 
		{
			Login = login;
			Password = password;
			AccessLevele = accessLvl;
			PersonData = personalData;
		}
	}
}