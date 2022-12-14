using MauiSamples.ViewModels;
using MauiSamples.Views.Popups;
using Mopups.Services;

namespace MauiSamples.Views;

public partial class AddressPage
{
    public AddressPage()
    {
        InitializeComponent();

        var vm = new AddressViewModelSourceGen
        //var vm = new AddressViewModel
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