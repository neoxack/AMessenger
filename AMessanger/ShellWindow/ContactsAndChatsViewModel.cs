using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Caliburn.Micro;

namespace AMessanger.ShellWindow
{
	public interface IListItem
	{
		string Name { get; set; }
	}

	public class ChatItem : PropertyChangedBase, IListItem
	{
		private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}


		public ChatItem(string name)
		{
			Name = name;
		}
	}

	public class ContactItem : PropertyChangedBase, IListItem
	{
		private string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}

		private string _time;
		public string Time
		{
			get { return _time; }
			set
			{
				_time = value;
				NotifyOfPropertyChange(() => Time);
			}
		}

		public ContactItem(string name, string time)
		{
			Name = name;
			Time = time;
		}
	}


	public class ContactsAndChatsViewModel : PropertyChangedBase
	{
		public BindableCollection<ChatItem> Chats { get; private set; }
		public BindableCollection<ContactItem> Contacts { get; private set; }

		public ContactsAndChatsViewModel()
		{
			Chats = new BindableCollection<ChatItem>();

			Chats.Add(new ChatItem("api"));
			Chats.Add(new ChatItem("general"));
			Chats.Add(new ChatItem("marketing"));

			Contacts = new BindableCollection<ContactItem>();

			Contacts.Add(new ContactItem("SashaGrey", "8:16"));
			Contacts.Add(new ContactItem("boris", "13:26"));
			Contacts.Add(new ContactItem("EricCartman", "5.01.15"));
			Contacts.Add(new ContactItem("jessica", "2.02.15"));
			Contacts.Add(new ContactItem("putin", "12:18"));
		}
	}
}
