using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.UserData
{
	public class PersonalData
	{
		public string Name { get; private set; }
		public string Surname { get; private set; }
		public string Patronymic { get; private set; }
		public string Yearsold { get; private set; }

		public PersonalData(string name, string surname, string patronymic, string yearsold)
		{
			Name = name;
			Surname = surname;
			Patronymic = patronymic;
			Yearsold = yearsold;
		}
	}
}
