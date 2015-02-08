using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Shapes;

namespace AMessanger.Converters
{
	public class BoolToPathConverter: IValueConverter
	{
		public Path PathForTrue { private get; set; }
		public Path PathForFalse { private get; set; } 

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			bool state = (bool)(value);
			if (state == true)
				return PathForTrue;
			return PathForFalse;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
