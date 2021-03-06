﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Offbeat.GitWorkbench.Common
{
	public class EmptyStringToHiddenVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (string.IsNullOrEmpty(value as string))
			{
				return Visibility.Hidden;
			}

			return Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}