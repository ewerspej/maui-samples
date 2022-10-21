using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;
using MauiSamples.Services;

namespace MauiSamples.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel
{
    public MainViewModel()
    {
        AppTheme = SettingsService.Instance.Theme;
    }

    [ObservableProperty]
    private Theme _appTheme;

    partial void OnAppThemeChanged(Theme value)
    {
        SettingsService.Instance.Theme = value;
    }
}