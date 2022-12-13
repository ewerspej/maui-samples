using MauiSamples.ViewModels;
using MauiSamples.Views.Popups;
using Mopups.Services;

namespace MauiSamples.Views;

public partial class MvvmSamplePage : ContentPage
{
    public MvvmSamplePage()
    {
        InitializeComponent();

        var vm = new MvvmSampleViewModel
        {
            DisplayAddress = DisplayAddressAsync
        };

        BindingContext = vm;
    }

    private static async void DisplayAddressAsync(string address)
    {
        await MopupService.Instance.PushAsync(new AddressPopup(address));
    }
}