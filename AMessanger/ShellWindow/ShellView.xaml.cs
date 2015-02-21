using System.Windows;
using System.Windows.Controls;
using System.Windows.Shell;

namespace AMessanger.ShellWindow
{
	public partial class ShellView: Window
	{
		public ShellView()
		{
			WindowChrome chrome = new WindowChrome
			{
				ResizeBorderThickness = new Thickness(10),
				CaptionHeight = 1.0		
			};
			WindowChrome.SetWindowChrome(this, chrome);
		}

		private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.DragMove();
		}
		
	}
}
