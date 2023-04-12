using System.Diagnostics;

namespace MauiSamples.Services.Device.Platform;

public partial class DeviceService : IDeviceService
{
    private static DeviceService _instance;
    public static DeviceService Instance => _instance ??= new DeviceService();

    private DeviceService() {}

    public partial void SetStatusBarColor(Color color, bool isLight);

    public void SetScreenBrightness(float brightness)
    {
        SetPlatformBrightness(brightness);
        Debug.WriteLine($"Brightness set to {brightness:F}");
    }
    
    private partial void SetPlatformBrightness(float brightness);
}