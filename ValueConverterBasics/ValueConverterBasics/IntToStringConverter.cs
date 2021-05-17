using System;
using System.Globalization;
using System.Windows.Data;

namespace ValueConverterBasics
{
    class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null)
                return System.Convert.ToInt32(value) >= System.Convert.ToInt32(parameter) ? "Passed" : "Failed";
            else
                return System.Convert.ToInt32(value) >= 60 ? "Passed" : "Failed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) < 15 ? false : true;
        }
    }
}
