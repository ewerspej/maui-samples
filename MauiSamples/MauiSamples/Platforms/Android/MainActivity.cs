using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace MauiSamples;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
//#if ANDROID30_0_OR_GREATER
//        if (Build.VERSION.SdkInt >= BuildVersionCodes.R) //R == API level 30.0
//        {
//            Window?.InsetsController?.Hide(WindowInsets.Type.SystemBars());
//        }
//#endif
    }
}
