using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Navigation;
using MauiSamples.Services;
using MauiSamples.Services.Audio;
using MauiSamples.Services.Device;

namespace MauiSamples.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IDeviceService _deviceService;
    private readonly IAudioService _audioService;
    private readonly INavigationService _navigationService;

    public MainViewModel(IDeviceService deviceService, INavigationService navigationService)
    {
        _deviceService = deviceService;
        _navigationService = navigationService;

        // we can also pull in the a service via the static ServiceHelper class, but that's not recommended as it makes dependencies opaque and fosters the Service Locator anti-pattern
        //_audioService = ServiceHelper.GetService<IAudioService>();
    }

    [RelayCommand]
    public void SetHighBrightness()
    {
        _deviceService.SetScreenBrightness(1.0f);
    }

    [RelayCommand]
    public void SetLowBrightness()
    {
        _deviceService.SetScreenBrightness(0.1f);
    }

    [ObservableProperty]
    private double _radius = 100.0;

    [RelayCommand]
    public async Task GoToGraphicsPageAsync()
    {
        await _navigationService.GoToAsync(Routes.GraphicsPage);
    }
}