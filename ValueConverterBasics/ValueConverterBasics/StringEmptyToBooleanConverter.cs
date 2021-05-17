using System;
using System.Globalization;
using System.Windows.Data;

namespace ValueConverterBasics
{
    class StringEmptyToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Equals(string.Empty) ? false : true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) < 15 ? false : true;
        }
    }
}
