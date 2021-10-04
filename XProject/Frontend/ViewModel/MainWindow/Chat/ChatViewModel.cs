using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Backend.Model.Chat;
using Frontend.ViewModel.Core;

namespace Frontend_View.ViewModel
{
	public class ChatViewModel : ObservableObjcet
	{
		public ObservableCollection<MessageModel> Messages { get; set; }
		public ObservableCollection<ContactModel> Contacts { get; set; }

		/*Commands*/
		public DelegateCommand SendCommand { get; set; }

		#region Property
		private ContactModel _selecteedContact;
		public ContactModel SelectedContact
		{
			get { return _selecteedContact; }
			set 
			{ 
				_selecteedContact = value;
				OnPropertyChanged();
			}
		}

		private string _message;
		public string Message
		{
			get { return _message; }
			set 
			{
				_message = value;
				OnPropertyChanged();
			}
		}
		#endregion

		public ChatViewModel()
		{
			Messages = new ObservableCollection<MessageModel>();
			Contacts = new ObservableCollection<ContactModel>();

			SendCommand = new DelegateCommand(o => 
			{
				Messages.Add(new MessageModel
				{
					Message = Message,
					FirstMessage = false
				});

				Message = "";
			});
		}
	}
}

/*
		 
			Messages.Add(new MessageModel
			{
				UserName = "Black Mamba",
				UserNameColor = "White",
				ImageSource = "https://i.imgur.com/yMWvLXd.png",
				Message = "Hello world",
				Time = DateTime.Now,
				IsNativeOrigin = false,
				FirstMessage = true
			});

			for (int i = 0; i < 3; i++)
			{
				Messages.Add(new MessageModel
				{
					UserName = "Black Mamba",
					UserNameColor = "White",
					ImageSource = "https://i.imgur.com/yMWvLXd.png",
					Message = "Hello world im Black",
					Time = DateTime.Now,
					IsNativeOrigin = false,
					FirstMessage = false
				});
			}

			for (int i = 0; i < 4; i++)
			{
				Messages.Add(new MessageModel
				{
					UserName = "Slave",
					UserNameColor = "White",
					ImageSource = "https://i.imgur.com/yMWvLXd.png",
					Message = "Hello slaves world",
					Time = DateTime.Now,
					IsNativeOrigin = true
				});
			}

			Messages.Add(new MessageModel
			{
				UserName = "Slave",
				UserNameColor = "White",
				ImageSource = "https://i.imgur.com/yMWvLXd.png",
				Message = "My Last message",
				Time = DateTime.Now,
				IsNativeOrigin = true
			});

			for (int i = 0; i < 5; i++)
			{
				Contacts.Add(new ContactModel
				{
					UserName = $"Black Mamba({i})",
					ImageSource = "https://i.imgur.com/yMWvLXd.png",
					Messages = Messages
				});
			}
		 */