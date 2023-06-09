using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Services;
using MauiSamples.Services.Audio;
using MauiSamples.Services.Device;

namespace MauiSamples.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IDeviceService _deviceService;
    private readonly IAudioService _audioService;

    public MainViewModel(IDeviceService deviceService)
    {
        _deviceService = deviceService;

        // we can also pull in the a service via the static ServiceHelper class
        _audioService = ServiceHelper.GetService<IAudioService>();
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
}