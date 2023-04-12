using Android.OS;
using Android.Views;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using AndroidPlatform = Microsoft.Maui.ApplicationModel.Platform;

namespace MauiSamples.Services.Device.Platform;

partial class DeviceService
{
    private partial void SetPlatformBrightness(float brightness)
    {
        if (AndroidPlatform.CurrentActivity?.Window?.Attributes == null)
        {
            return;
        }

        var attributes = AndroidPlatform.CurrentActivity.Window.Attributes;
        attributes.ScreenBrightness = brightness;
        AndroidPlatform.CurrentActivity.Window.Attributes = attributes;
    }

    public partial void SetStatusBarColor(Color color, bool isLight)
    {
        if (AndroidPlatform.CurrentActivity?.Window == null || Build.VERSION.SdkInt < BuildVersionCodes.O)
        {
            return;
        }

        AndroidPlatform.CurrentActivity.Window.SetStatusBarColor(color.ToAndroid());

        if (Build.VERSION.SdkInt < BuildVersionCodes.R)
        {
            if (AndroidPlatform.CurrentActivity?.Window == null)
            {
                return;
            }

            var current = AndroidPlatform.CurrentActivity.Window.DecorView.SystemUiVisibility;

            if (isLight)
            {
                current = (StatusBarVisibility)((SystemUiFlags)current | SystemUiFlags.LightStatusBar);
            }
            else
            {
                current = (StatusBarVisibility)((SystemUiFlags)current ^ SystemUiFlags.LightStatusBar);
            }

            AndroidPlatform.CurrentActivity.Window.DecorView.SystemUiVisibility = current;
        }
        else
        {
            var statusBarFlags = isLight ? (int)WindowInsetsControllerAppearance.LightStatusBars : 0;
            AndroidPlatform.CurrentActivity?.Window?.InsetsController?.SetSystemBarsAppearance(statusBarFlags, (int)WindowInsetsControllerAppearance.LightStatusBars);
        }
    }
}