using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RagoOptimiser.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private object? _currentView;

    public object? CurrentView
    {
        get => _currentView;
        set
        {
            if (_currentView == value) return;
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainWindowViewModel()
    {
        CurrentView = new Views.LoginView();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
