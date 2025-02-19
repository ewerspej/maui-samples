using System.Globalization;

namespace MauiSamples.Converters;

public sealed class FuncValueToBoolConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values[0] is Func<object, bool> func)
        {
            return func(values[1]);
        }

        return false;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        return [];
    }
}