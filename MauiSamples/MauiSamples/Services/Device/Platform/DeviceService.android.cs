using Android.OS;
using Android.Views;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace MauiSamples.Services.Device.Platform;

static partial class DeviceService
{
    private static MainActivity _activity;
    public static void SetActivity(MainActivity activity)
    {
        _activity = activity;
    }

    public static partial void SetStatusBarColor(Color color, bool isLight)
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