using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;

namespace MauiSamples.Services.Settings;

[INotifyPropertyChanged]
public partial class SettingsService
{
    private static SettingsService _instance;
    public static SettingsService Instance => _instance ??= new SettingsService();

    private SettingsService()
    {
        Theme = Theme.System;
    }

    [ObservableProperty]
    private Theme _theme;
}