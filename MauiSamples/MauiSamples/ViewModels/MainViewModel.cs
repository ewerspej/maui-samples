using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;
using MauiSamples.Services;

namespace MauiSamples.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel
{
    public MainViewModel()
    {
        AppTheme = Theme.System;
    }

    public List<Theme> AvailableThemes { get; } = new() { Theme.System, Theme.Light, Theme.Dark };

    [ObservableProperty]
    private Theme _appTheme;

    partial void OnAppThemeChanged(Theme value)
    {
        SettingsService.Instance.AppTheme = value;
    }
}