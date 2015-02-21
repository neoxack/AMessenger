using System.Windows;
using System.Windows.Controls;
using AMessanger.ShellWindow;

namespace AMessanger.TemplateSelectors
{
	public class MessageItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate NormalTemplate
		{
			get;
			set;
		}
		public DataTemplate TimeStampTemplate
		{
			get;
			set;
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			MessageItem product = (MessageItem)item;

			if (product.Type == MessageType.Normal)
			{
				return NormalTemplate;
			}
			else
			{
				return TimeStampTemplate;
			}
		}
	}
}
