using System;
using System.Globalization;
using System.Windows.Data;

namespace ProjectCDA.Converter
{
    public class RightPageIDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 2 * (int)value + 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
