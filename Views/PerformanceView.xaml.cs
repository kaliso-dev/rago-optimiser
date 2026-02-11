using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RagoOptimiser.Views;

public partial class PerformanceView : UserControl
{
    public PerformanceView()
    {
        InitializeComponent();
        Loaded += (_, _) =>
        {
            BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(350)));

            var glow = new DoubleAnimation(0.35, 0.85, TimeSpan.FromSeconds(1.2))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                EasingFunction = new SineEase { EasingMode = EasingMode.EaseInOut }
            };

            CpuSelectedButton.BeginAnimation(OpacityProperty, glow);
        };
    }
}
