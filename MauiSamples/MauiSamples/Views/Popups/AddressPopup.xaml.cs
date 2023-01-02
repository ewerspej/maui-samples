using Mopups.Pages;
using Mopups.Services;

namespace MauiSamples.Views.Popups;

public partial class AddressPopup : PopupPage
{
	private string _address;
    public string Address
    {
        get => _address;
        set
        {
            _address = value;
            OnPropertyChanged();
        }
    }

	public AddressPopup(string address)
	{
		InitializeComponent();
        BindingContext = this;
        Address = address;
    }

    private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}