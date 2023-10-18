namespace MauiSamples.Views.Platform;

public partial class PageWithPlatformSpecificView : ContentPage
{
	public PageWithPlatformSpecificView()
	{
		InitializeComponent();

        //Conditional compilation approach
#if ANDROID
		VerticalLayout.Add(new Android.ViewAndroid());
#elif IOS
        VerticalLayout.Add(new iOS.ViewiOS());
#else
        var contentView = new ContentView
        {
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Fill,
            Padding = new Thickness(10.0)
        };
        var label = new Label
        {
            Text = "This is neither Android nor iOS",
            HorizontalOptions = LayoutOptions.Center
        };
        contentView.Content = label;
        VerticalLayout.Add(contentView);
#endif

        //Runtime approach
        //if (DeviceInfo.Platform == DevicePlatform.Android)
        //{
        //    VerticalLayout.Add(new Android.ViewAndroid());
        //}
        //else if (DeviceInfo.Platform == DevicePlatform.iOS)
        //{
        //    VerticalLayout.Add(new iOS.ViewiOS());
        //}
        //else
        //{
        //    var contentView = new ContentView
        //    {
        //        VerticalOptions = LayoutOptions.Start,
        //        HorizontalOptions = LayoutOptions.Fill,
        //        Padding = new Thickness(10.0)
        //    };
        //    var label = new Label
        //    {
        //        Text = "This is neither Android nor iOS",
        //        HorizontalOptions = LayoutOptions.Center
        //    };
        //    contentView.Content = label;
        //    VerticalLayout.Add(contentView);
        //}
    }
}