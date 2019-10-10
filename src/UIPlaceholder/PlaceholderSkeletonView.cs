using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace UIPlaceholder
{
    public class PlaceholderSkeletonView : Grid
    {
        Storyboard myLoadingStoryboard { get; set; }
        public PlaceholderSkeletonView()
        {
            myLoadingStoryboard = new Storyboard();
            var blinkAnimation = new DoubleAnimation()
            {
                From = 1,
                To = 0.4,
                AutoReverse = true,
                //blink every 1sec
                Duration = new Windows.UI.Xaml.Duration(TimeSpan.FromSeconds(1)),
                RepeatBehavior = RepeatBehavior.Forever
            };

            myLoadingStoryboard.Children.Add(blinkAnimation);

            Storyboard.SetTarget(myLoadingStoryboard, this);
            Storyboard.SetTargetProperty(blinkAnimation, "Opacity");

            Loaded += (a, e) => myLoadingStoryboard.Begin();
        }
    }
}
