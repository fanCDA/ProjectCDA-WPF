using System;
using System.Globalization;
using System.Windows.Data;

namespace ProjectCDA.Converter
{
    public class LeftPageIDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int ID = (int)value;
            switch (ID)
            {
                case 0:
                    return "I";
                case 1:
                    return "III";
                default:
                    return 2 * ID - 2;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
