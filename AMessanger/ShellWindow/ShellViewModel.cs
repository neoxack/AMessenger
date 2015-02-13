using System.Windows;
using Caliburn.Micro;

namespace AMessanger.ShellWindow
{

	public class MessageItem
	{
		public string Image { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
		public string Content { get; set; }

		public MessageItem(string image, string name, string time, string content)
		{
			Image = image;
			Name = name;
			Time = time;
			Content = content;
		}
	}

	public class ShellViewModel : Screen
	{

		public ContactsAndChatsViewModel ContactsAndChatsViewModel { get; set; }

		public BindableCollection<MessageItem> Messages { get; set; } 

		public ShellViewModel()
		{
			ContactsAndChatsViewModel = new ContactsAndChatsViewModel();
			Messages = new BindableCollection<MessageItem>();
			Messages.Add(new MessageItem("\\Resources\\user1.png", "SashaGrey", "11:47", "Hello! Do you seen my new film?))"));
			Messages.Add(new MessageItem("\\Resources\\user2.png", "neoCortex", "11:48", "Hi! Yes, of course :)\nHi! Yes, of course :)Hi! Yes, of course :)Hi! Yes, of course :)Hi! Yes, of course :)Hi! Yes, of course :)Hi! Yes, of course :)Hi! Yes, of course :)"));
			Messages.Add(new MessageItem("\\Resources\\user1.png", "SashaGrey", "11:48", "Это очень хорошо!"));
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