using System;
using System.Windows;
using System.Windows.Data;


namespace WPFCommon.Converters
{
    [ValueConversion(typeof(Visibility), typeof(Visibility))]
    public class InversedVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }
        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
