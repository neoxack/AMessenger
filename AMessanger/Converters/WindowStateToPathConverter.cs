using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Shapes;

namespace AMessanger.Converters
{
	public class WindowStateToPathConverter: IValueConverter
	{
		public Path PathForNormalState { private get; set; }
		public Path PathForMaximizedState { private get; set; } 

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			WindowState state = (WindowState)(value);
			if (state == WindowState.Maximized)
				return PathForMaximizedState;
			return PathForNormalState;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
