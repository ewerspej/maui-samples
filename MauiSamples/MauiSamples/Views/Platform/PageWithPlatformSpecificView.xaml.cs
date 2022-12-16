namespace MauiSamples.Views.Platform;

public partial class PageWithPlatformSpecificView : ContentPage
{
	public PageWithPlatformSpecificView()
	{
		InitializeComponent();

        //Conditional compilation approach
#if ANDROID
		VerticalLayout.Add(new ViewAndroid());
#elif IOS
        VerticalLayout.Add(new ViewiOS());
#endif

        //Runtime approach
        //if (DeviceInfo.Platform == DevicePlatform.Android)
        //{
        //    VerticalLayout.Add(new ViewAndroid());
        //}
        //
        //if (DeviceInfo.Platform == DevicePlatform.iOS)
        //{
        //    VerticalLayout.Add(new ViewiOS());
        //}
    }
}