using MauiSamples.Models;
using MauiSamples.Navigation;
using MauiSamples.ViewModels;
using MauiSamples.Views.Platform;

namespace MauiSamples.Views;

public partial class MainPage
{
    private readonly INavigationService _navigationService;

    public MainPage(MainViewModel viewModel, INavigationService navigationService)
    {
        _navigationService = navigationService;

        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void SayHello(object sender, EventArgs e)
    {
#if ANDROID || IOS || MACCATALYST || WINDOWS
        await this.SayHello();
#endif
    }

    private async void OpenHelloView(object sender, EventArgs e)
    {
        //Conditional compilation approach (preferred)
#if ANDROID
        await Navigation.PushAsync(new Platform.Android.HelloFromAndroid());
#elif IOS
        await Navigation.PushAsync(new Platform.iOS.HelloFromiOS());
#else
        await Navigation.PushAsync(new Platform.Other.HelloFromOther());
#endif

        //Runtime approach
        //if (DeviceInfo.Platform == DevicePlatform.Android)
        //{
        //    await Navigation.PushAsync(new Platform.Android.HelloFromAndroid());
        //}
        //else if (DeviceInfo.Platform == DevicePlatform.iOS)
        //{
        //    await Navigation.PushAsync(new Platform.iOS.HelloFromiOS());
        //}
        //else
        //{
        //    await Navigation.PushAsync(new Platform.Other.HelloFromOther());
        //}
    }

    private async void OpenWithPlatformView(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageWithPlatformSpecificView());
    }

    private async void OnGraphicsPageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GraphicsPage());
    }

    private async void OnMultiBindingPageButtonClicked(object sender, EventArgs e)
    {
        await _navigationService.GoToAsync(Routes.MultiBindingPage);
    }

    private async void OnPassPersonButtonClicked(object sender, EventArgs e)
    {
        await _navigationService.GoToAsync($"{Routes.PassObjectsPage}?Name={"John"}&Age={59}&IsMarried={true}", parameters: new Dictionary<string, object>
        {
            {
                "Somebody",
                new Person
                {
                    FirstName = "John",
                    LastName = "Jones",
                    Age = 66,
                    IsMarried = true
                }
            }
        });
    }

    private async void OnAccordionOneButtonPressed(object sender, EventArgs e)
    {
        await _navigationService.GoToAsync(Routes.AccordionOnePage);
    }

    private async void OnAccordionTwoButtonPressed(object sender, EventArgs e)
    {
        await _navigationService.GoToAsync(Routes.AccordionMvvmPage);
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await _navigationService.GoToAsync(Routes.PageWithBase);
    }
}