using MauiSamples.Models;
using MauiSamples.Services;
using System.ComponentModel;

namespace MauiSamples;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        SetTheme();

        SettingsService.Instance.PropertyChanged += OnSettingsPropertyChanged;
    }

    private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(SettingsService.AppTheme))
        {
            SetTheme();
        }
    }

    private void SetTheme()
    {
        if (SettingsService.Instance.AppTheme == Theme.Light)
        {
            UserAppTheme = AppTheme.Light;
        }

        if (SettingsService.Instance.AppTheme == Theme.Dark)
        {
            UserAppTheme = AppTheme.Dark;
        }

        if (SettingsService.Instance.AppTheme == Theme.System)
        {
            UserAppTheme = AppTheme.Unspecified;
        }
    }
}
