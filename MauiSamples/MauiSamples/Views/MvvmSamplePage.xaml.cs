using MauiSamples.ViewModels;
using MauiSamples.Views.Popups;
using Mopups.Services;

namespace MauiSamples.Views;

public partial class MvvmSamplePage : ContentPage
{
    public MvvmSamplePage()
    {
        InitializeComponent();

        var vm = new MvvmSampleGenViewModel
        //var vm = new MvvmSampleViewModel
        {
            OnPrintAddress = DisplayAddressAsync
        };

        BindingContext = vm;
    }

    private static async void DisplayAddressAsync(string address)
    {
        await MopupService.Instance.PushAsync(new AddressPopup(address));
    }
}