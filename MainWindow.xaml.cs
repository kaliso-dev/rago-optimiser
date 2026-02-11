using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Animation;
using RagoOptimiser.ViewModels;
using RagoOptimiser.Views;

namespace RagoOptimiser;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _viewModel;

    public MainWindow()
    {
        InitializeComponent();
        _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;
        Loaded += OnLoaded;
        _viewModel.PropertyChanged += OnViewModelPropertyChanged;
    }

    public void NavigateToLogin() => _viewModel.CurrentView = new LoginView();

    public void NavigateToMainMenu() => _viewModel.CurrentView = new MainMenuView();

    public void NavigateToPerformance() => _viewModel.CurrentView = new PerformanceView();

    public void NavigateToInputLag() => _viewModel.CurrentView = new InputLagView();

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        BeginFadeIn();
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(MainWindowViewModel.CurrentView))
        {
            return;
        }

        BeginFadeIn();
    }

    private void BeginFadeIn()
    {
        var animation = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(320))
        {
            EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut }
        };

        RootContent.BeginAnimation(OpacityProperty, animation);
    }
}
