using UIKit;

namespace MauiSamples.Services.Device.Platform;

partial class DeviceService
{
    public partial void SetScreenBrightness(float brightness)
    {
        UIScreen.MainScreen.Brightness = brightness;
    }

    public partial void SetStatusBarColor(Color color, bool isLight)
    {
        //ignore
    }
}