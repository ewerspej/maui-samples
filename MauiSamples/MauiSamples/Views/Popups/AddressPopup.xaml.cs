using Mopups.Pages;
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
}