using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RagoOptimiser.Views;

public partial class InputLagView : UserControl
{
    public InputLagView()
    {
        InitializeComponent();
        Loaded += (_, _) =>
        {
            BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(350)));

            var pulse = new DoubleAnimation(0.55, 1, TimeSpan.FromSeconds(1.1))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                EasingFunction = new SineEase { EasingMode = EasingMode.EaseInOut }
            };
            WindowsLatencyButton.BeginAnimation(OpacityProperty, pulse);
        };
    }
}
