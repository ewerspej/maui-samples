using UIKit;

namespace MauiSamples.Services.Device.Platform;

partial class DeviceService
{
    private partial void SetPlatformBrightness(float brightness)
    {
        UIScreen.MainScreen.Brightness = brightness;
    }

    public partial void SetStatusBarColor(Color color, bool isLight)
    {
        //ignore
    }
}