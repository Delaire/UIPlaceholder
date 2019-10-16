using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UIPlaceholder
{
    public class PlaceholderStateManager
    {
        public IList<PlaceholderStateItem> PlaceholderItems { get; set; }

        private IList<UIElement> _savedContent { get; set; }
        private PlaceholderState _previousState = PlaceholderState.NoState;

        public PlaceholderStateManager(Grid g)
        {
            _savedContent = g.Children.ToList();
        }

        internal void SwitchToAppContent(Grid g)
        {
            _previousState = PlaceholderState.NoState;

            //clear placeholder state
            g.Children.Clear();

            // Put the original content back in.
            foreach (var item in _savedContent)
            {
                g.Children.Add(item);
            }
        }


        internal void SwitchToPlaceholderTemplate(Grid layout, PlaceholderState placeholderState)
        {
            // save original content if not already done
            if (_previousState == PlaceholderState.NoState)
            {
                _savedContent = layout.Children.ToList();
            }

            _previousState = placeholderState;

            //get PlaceholderStateItem
            var template = GetPlaceholderTemplate(placeholderState);
            int repeat = template.RepeatItem;
            DataTemplate itemTemplate = template.PlaceholderTemplate;

            //clear UI
            layout.Children.Clear();

            //if reapet = 1 or we can find an item template then only repeat this once
            if (repeat == 1 || itemTemplate == null)
            {
                layout.Children.Add(template);
            }
            else
            {
                var repeatItemsSource = new List<int>();
                for (int i = 0; i < repeat; i++)
                {
                    repeatItemsSource.Add(repeat);
                }

                var ls = new ListView();
                ls.SelectionMode = ListViewSelectionMode.None;
                ls.ShowsScrollingPlaceholders = false;
                //ls.CanBeScrollAnchor = false;

                //insert template
                ls.ItemTemplate = itemTemplate;
                ls.ItemsSource = repeatItemsSource;

                layout.Children.Add(ls);
            }
        }


        private PlaceholderStateItem GetPlaceholderTemplate(PlaceholderState placeholderState)
        {
            var template = PlaceholderItems.Where(a => a.StateItemKey == placeholderState).FirstOrDefault();

            return template;
        }
    }
}
