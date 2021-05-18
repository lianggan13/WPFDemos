using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFCommon.Converters
{
    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && bool.Parse(value.ToString()))
            {
                return Brushes.LightGreen;
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
