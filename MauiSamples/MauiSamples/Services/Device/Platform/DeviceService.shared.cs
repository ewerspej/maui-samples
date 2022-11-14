namespace MauiSamples.Services.Device.Platform;

public partial class DeviceService : IDeviceService
{
    private static DeviceService _instance;
    public static DeviceService Instance => _instance ??= new DeviceService();

    private DeviceService() {}

    public partial void SetScreenBrightness(float brightness);

    public partial void SetStatusBarColor(Color color, bool isLight);
}