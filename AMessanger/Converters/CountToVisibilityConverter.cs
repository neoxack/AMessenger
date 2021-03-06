﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AMessanger.Converters
{
	public class CountToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			uint val = (uint)value;
			if (val == 0) return Visibility.Collapsed;
			return Visibility.Visible;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
