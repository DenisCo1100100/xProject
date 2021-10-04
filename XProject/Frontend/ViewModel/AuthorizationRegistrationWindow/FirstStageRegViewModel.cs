using System;
using System.Collections.Generic;
using System.Text;
using Frontend.ViewModel.Core;
using Frontend_View.ViewModel;
using HandyControl.Controls;

namespace Frontend.ViewModel.AuthorizationRegistrationWindow
{
	public class FirstStageRegViewModel : ObservableObjcet
	{
		#region Property
		private string _name;
		public string Name 
		{ 
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged("Name");
			}
		}

		private string _surname;
		public string Surname
		{
			get { return _surname; }
			set
			{
				_surname = value;
				OnPropertyChanged("Surname");
			}
		}

		private string _patronomyc;
		public string Patronomyc
		{
			get { return _patronomyc; }
			set
			{
				_patronomyc = value;
				OnPropertyChanged("Patronomyc");
			}
		}
		#endregion

		public FirstStageRegViewModel()
		{
			OpenSecondStageReg = new DelegateCommand(o =>
			{
				UserApi.User user = new UserApi.User
				{
					PersonalData = new UserApi.PersonalData
					{
						Name = Name,
						Surname = Surname,
						Patronymic = Patronomyc,
						Yearsold = "10.10.2010"
					}
				};

				RootViewModel.GetInstance().CurrentContentVM = new SecondStageRegViewModel(user);
			});

			OpenAuthorization = new DelegateCommand(o =>
			{
				RootViewModel.GetInstance().CurrentContentVM = new AuthorizationViewModel();
			});
		}

		/*COMMAND*/

		public DelegateCommand OpenSecondStageReg { get; private set; }
		public DelegateCommand OpenAuthorization { get; private set; }
	}
}