using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UIPlaceholder
{
    public class PlaceholderStateItem : ItemsControl
    {
        public static readonly DependencyProperty StateItemKeyProperty = DependencyProperty.Register(
            "StateItemKey",
            typeof(PlaceholderState),
            typeof(PlaceholderStateItem),
            new PropertyMetadata(default(PlaceholderState)));
        
        public PlaceholderState StateItemKey
        {
            get { return (PlaceholderState)GetValue(StateItemKeyProperty); }
            set { SetValue(StateItemKeyProperty, value); }
        }


        public static readonly DependencyProperty RepeatItemProperty = DependencyProperty.Register(
            "RepeatItem",
            typeof(int),
            typeof(PlaceholderStateItem),
            new PropertyMetadata(1));
        
        public int RepeatItem
        {
            get { return (int)GetValue(RepeatItemProperty); }
            set { SetValue(RepeatItemProperty, value); }
        }

        public static readonly DependencyProperty PlaceholderTemplateProperty = DependencyProperty.Register(
            "PlaceholderTemplate",
            typeof(DataTemplate),
            typeof(PlaceholderStateItem),
            new PropertyMetadata(null));
        
        public DataTemplate PlaceholderTemplate
        {
            get { return (DataTemplate)GetValue(PlaceholderTemplateProperty); }
            set { SetValue(PlaceholderTemplateProperty, value); }
        }



    }
}
