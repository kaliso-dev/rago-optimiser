using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RagoOptimiser.Views;

public partial class LoginView : UserControl
{
    public LoginView()
    {
        InitializeComponent();
        Loaded += (_, _) =>
        {
            var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(350));
            BeginAnimation(OpacityProperty, fadeIn);
        };
    }
}
