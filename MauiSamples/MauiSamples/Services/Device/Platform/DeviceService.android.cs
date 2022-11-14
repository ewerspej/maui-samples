using Android.OS;
using Android.Views;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace MauiSamples.Services.Device.Platform;

partial class DeviceService
{
    private static MainActivity _activity;
    public static void SetActivity(MainActivity activity)
    {
        _activity = activity;
    }

    public partial void SetScreenBrightness(float brightness)
    {
        if (_activity?.Window?.Attributes == null)
        {
            return;
        }

        var attributes = _activity.Window.Attributes;
        attributes.ScreenBrightness = brightness;
        _activity.Window.Attributes = attributes;
    }

    public partial void SetStatusBarColor(Color color, bool isLight)
    {
        if (_activity?.Window == null || Build.VERSION.SdkInt < BuildVersionCodes.O)
        {
            return;
        }

        _activity.Window.SetStatusBarColor(color.ToAndroid());

        if (Build.VERSION.SdkInt < BuildVersionCodes.R)
        {
            if (_activity?.Window == null)
            {
                return;
            }

            var current = _activity.Window.DecorView.SystemUiVisibility;

            if (isLight)
            {
                current = (StatusBarVisibility)((SystemUiFlags)current | SystemUiFlags.LightStatusBar);
            }
            else
            {
                current = (StatusBarVisibility)((SystemUiFlags)current ^ SystemUiFlags.LightStatusBar);
            }

            _activity.Window.DecorView.SystemUiVisibility = current;
        }
        else
        {
            var statusBarFlags = isLight ? (int)WindowInsetsControllerAppearance.LightStatusBars : 0;
            _activity?.Window?.InsetsController?.SetSystemBarsAppearance(statusBarFlags, (int)WindowInsetsControllerAppearance.LightStatusBars);
        }
    }
}