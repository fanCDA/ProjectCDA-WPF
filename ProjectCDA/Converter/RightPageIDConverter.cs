using System;
using System.Globalization;
using System.Windows.Data;

namespace ProjectCDA.Converter
{
    public class RightPageIDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int ID = (int)value;
            switch (ID)
            {
                case 0:
                    return "II";
                case 1:
                    return "IV";
                default:
                    return 2 * ID - 1;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
