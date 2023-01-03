using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Services.Device;

namespace MauiSamples.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IDeviceService _deviceService;

    public MainViewModel(IDeviceService deviceService)
    {
        _deviceService = deviceService;
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
}