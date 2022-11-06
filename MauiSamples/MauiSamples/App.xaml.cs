using MauiSamples.Services.Device.Platform;
using MauiSamples.Services.Settings;
using System.ComponentModel;

namespace MauiSamples;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        // let's set the initial theme already during the app start
        SetTheme();

        // subscribe to changes in the settings
        SettingsService.Instance.PropertyChanged += OnSettingsPropertyChanged;
    }

    private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(SettingsService.Theme))
        {
            SetTheme();
        }
    }

    private void SetTheme()
    {
        UserAppTheme = SettingsService.Instance?.Theme != null
                     ? SettingsService.Instance.Theme.AppTheme
                     : AppTheme.Unspecified;

        switch (UserAppTheme)
        {
            case AppTheme.Light:
                DeviceService.SetStatusBarColor(Colors.White, true);
                break;
            case AppTheme.Dark:
                DeviceService.SetStatusBarColor(Colors.Black, false);
                break;
            case AppTheme.Unspecified when RequestedTheme == AppTheme.Light:
                DeviceService.SetStatusBarColor(Colors.White, true);
                break;
            case AppTheme.Unspecified:
                DeviceService.SetStatusBarColor(Colors.Black, false);
                break;
        }

        try
        {
#if ANDROID || WINDOWS
            ICollection<ResourceDictionary> mergedDictionaries = Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new MauiSamples.Resources.Styles.SpecialStyles());
            }
#endif
        }
        catch
        {
            //ignore
        }
    }
}
