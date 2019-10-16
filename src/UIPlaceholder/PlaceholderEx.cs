using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UIPlaceholder
{
    public class PlaceholderEx : DependencyObject
    {        
        public static readonly DependencyProperty CurrentPlaceholderStateProperty = DependencyProperty.Register(
            "CurrentPlaceholderState",
            typeof(PlaceholderState),
            typeof(PlaceholderEx),
            new PropertyMetadata(PlaceholderState.NoState, OnCurrentPlaceholderStateChanged));

        public static PlaceholderState GetCurrentPlaceholderState(UIElement element)
        {
            return (PlaceholderState)element.GetValue(CurrentPlaceholderStateProperty);
        }
        public static void SetCurrentPlaceholderState(UIElement element, PlaceholderState value)
        {
            element.SetValue(CurrentPlaceholderStateProperty, value);
        }

        private static void OnCurrentPlaceholderStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            if (args != null && (args.NewValue != args.OldValue))
            {
                PlaceholderState state = (PlaceholderState)args.NewValue;

                //initialise
                if (layoutManager == null)
                {
                    layoutManager = (new PlaceholderStateManager(d as Grid)
                    {
                        PlaceholderItems = GetPlaceholderStateItems(d) as IList<PlaceholderStateItem>
                    });
                }


                if (layoutManager!=null)
                {
                    // set the layout to loading Template.
                    if (state == PlaceholderState.Loading)
                    {
                        layoutManager.SwitchToPlaceholderTemplate(d as Grid, state);
                    }
                    else if (state == PlaceholderState.NoState)
                    {
                        layoutManager.SwitchToAppContent(d as Grid);
                    }
                }
                
            }
        }

        ///PlaceholderView

        /// <summary>
        /// Attached <see cref="DependencyProperty"/> for binding a <see cref="Grid"/> as a placeholder template />
        /// </summary>
        public static readonly DependencyProperty PlaceholderViewsProperty =
            DependencyProperty.Register(
                "PlaceholderStateItems",
                typeof(IList<PlaceholderStateItem>),
                typeof(PlaceholderEx),
                new PropertyMetadata(null, OnPlaceholderViewPropertyChanged));

        //this has to be an object or it will break
        public static object GetPlaceholderStateItems(DependencyObject page)
        {
            var elements = (List<PlaceholderStateItem>)page.GetValue(PlaceholderViewsProperty);

            return elements;
        }

        //we can have one or many states
        public static void SetPlaceholderStateItems(DependencyObject element, object value)
        {
            if (value.GetType().Equals(typeof(PlaceholderStateItem)))
            {
                var newValue = new List<PlaceholderStateItem>();
                newValue.Add(value as PlaceholderStateItem);

                element.SetValue(PlaceholderViewsProperty, newValue);
            }
            else

            {
                element.SetValue(PlaceholderViewsProperty, value);
            }
        }



        private static void OnPlaceholderViewPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (args != null && (args.NewValue != args.OldValue))
            {
                //do nothing?
            }
        }

        private static IList<PlaceholderStateItem> GetGetPlaceholderItems()
        {
            var t = PlaceholderViewsProperty;
            return null;
        }


        internal static PlaceholderStateManager layoutManager { get; set; }

        //  static readonly DependencyProperty LayoutControllerProperty =
        //DependencyProperty.Register(
        //    "PlaceholderManager",
        //    typeof(PlaceholderStateManager),
        //    typeof(PlaceholderEx),
        //      new PropertyMetadata(new PlaceholderStateManager()
        //      {
        //          PlaceholderItems = null
        //      },
        //      null));

        //  public static PlaceholderStateManager GetPlaceholderManager(DependencyObject b)
        //  {
        //      return (PlaceholderStateManager)b.GetValue(LayoutControllerProperty);
        //  }


    }
}
