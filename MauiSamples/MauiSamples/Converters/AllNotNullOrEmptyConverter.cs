using System.Globalization;

namespace MauiSamples.Converters
{
    public class AllNotNullOrEmptyConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || !targetType.IsAssignableFrom(typeof(bool)))
            {
                return false;
            }

            foreach (var value in values)
            {
                if (value is not string b)
                {
                    return false;
                }

                if (string.IsNullOrWhiteSpace(b))
                {
                    return false;
                }
            }
            return true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return default;
        }
    }
}
