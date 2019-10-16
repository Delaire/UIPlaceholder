using System;
using Windows.UI.Xaml.Data;

namespace UIPlaceholder
{
    public class StateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is PlaceholderState state && parameter is PlaceholderState stateToCompare)
            {
                return state == stateToCompare;
            }

            return false;
        }

        //this is go back to the normal state of showing the classic information
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return PlaceholderState.NoState;
        }
    }
}
