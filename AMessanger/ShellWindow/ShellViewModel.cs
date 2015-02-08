using System.Windows;
using Caliburn.Micro;

namespace AMessanger.ShellWindow
{

	public class ShellViewModel : Screen
	{
		public ShellViewModel()
		{
			
			Text = "Autumn � Some Like It Crunchy";
		}

		public string Text { get; set; }

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