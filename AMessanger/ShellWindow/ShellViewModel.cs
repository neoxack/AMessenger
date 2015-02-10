using System.Windows;
using Caliburn.Micro;

namespace AMessanger.ShellWindow
{

	public class ShellViewModel : Screen
	{

		public ContactsAndChatsViewModel ContactsAndChatsViewModel { get; set; }

		public ShellViewModel()
		{
			ContactsAndChatsViewModel = new ContactsAndChatsViewModel();
		}



		public WindowState WindowState
		{
			get
			{
				var window = GetView() as Window;
				return window.WindowState;
			}
			set
			{
				var window = GetView() as Window;
				window.WindowState = value;
				NotifyOfPropertyChange(() => WindowState);
			}
		}

		public bool Topmost
		{
			get
			{
				var window = GetView() as Window;
				return window.Topmost;
			}
			set
			{
				var window = GetView() as Window;
				window.Topmost = value;
				NotifyOfPropertyChange(() => Topmost);
			}
		}

		public void Pin()
		{
			Topmost = !Topmost;
		}

		public void MinimizeWindow()
		{
			WindowState = WindowState.Minimized;
		}

		public void MaximizeWindow()
		{
			WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
		}

		public void CloseWindow()
		{
			var window = GetView() as Window;
			if (window != null) window.Close();
		}
	}
}