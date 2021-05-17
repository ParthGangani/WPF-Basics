using System;
using System.Globalization;
using System.Windows.Data;

namespace ValueConverterBasics
{
    class BooleanToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 5 : 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) < 15 ? false : true;
        }
    }
}
