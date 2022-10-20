using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;

namespace MauiSamples.Services;

[INotifyPropertyChanged]
public partial class SettingsService
{
    private static SettingsService _instance;
    public static SettingsService Instance => _instance ??= new SettingsService();

    private SettingsService() { }

    [ObservableProperty]
    private Theme _appTheme;
}