﻿using MauiSamples.Services.Device.Platform;
using MauiSamples.Services.Settings;
using System.ComponentModel;

namespace MauiSamples;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        // let's set the initial theme already during the app start
        SetTheme();

        // subscribe to changes in the settings
        SettingsService.Instance.PropertyChanged += OnSettingsPropertyChanged!;
    }

    protected override Window CreateWindow(IActivationState? activationState) => new(new AppShell());

    private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(SettingsService.Theme))
        {
            SetTheme();
        }
    }

    private void SetTheme()
    {
//        try
//        {
//            if (Current?.Resources.MergedDictionaries is not { } mergedDictionaries)
//            {
//                return;
//            }
//            mergedDictionaries.Clear();
//            mergedDictionaries.Add(new Resources.Styles.Colors());
//            mergedDictionaries.Add(new Resources.Styles.Styles());
//#if ANDROID || WINDOWS
//            mergedDictionaries.Add(new Resources.Styles.Platform.SpecialStyles());
//#endif
//        }
//        catch
//        {
//            //ignore
//        }

        UserAppTheme = SettingsService.Instance?.Theme != null
                     ? SettingsService.Instance.Theme.AppTheme
                     : AppTheme.Unspecified;

        switch (UserAppTheme)
        {
            case AppTheme.Light:
                DeviceService.Instance.SetStatusBarColor(Colors.White, true);
                break;
            case AppTheme.Dark:
                DeviceService.Instance.SetStatusBarColor(Colors.Black, false);
                break;
            case AppTheme.Unspecified when RequestedTheme == AppTheme.Light:
                DeviceService.Instance.SetStatusBarColor(Colors.White, true);
                break;
            case AppTheme.Unspecified:
                DeviceService.Instance.SetStatusBarColor(Colors.Black, false);
                break;
        }
    }
}
