using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace RagoOptimiser.Views;

public partial class MainMenuView : UserControl
{
    public MainMenuView()
    {
        InitializeComponent();
        Loaded += (_, _) =>
        {
            BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(350)));

            var transform = new TranslateTransform();
            LatencyPath.RenderTransform = transform;
            var pulse = new DoubleAnimation(-6, 6, TimeSpan.FromSeconds(2.1))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                EasingFunction = new SineEase { EasingMode = EasingMode.EaseInOut }
            };
            transform.BeginAnimation(TranslateTransform.XProperty, pulse);
        };
    }
}
