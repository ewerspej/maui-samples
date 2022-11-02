using Android.App;
using Android.Content.PM;
using Android.OS;
using MauiSamples.Services.Device.Platform;

namespace MauiSamples;

[Activity(Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        DeviceService.SetActivity(this);
    }
}
