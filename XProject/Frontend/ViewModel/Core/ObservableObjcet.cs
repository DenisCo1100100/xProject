using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Frontend.ViewModel.Core
{
	public class ObservableObjcet : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string propertyname = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
		}
	}
}
