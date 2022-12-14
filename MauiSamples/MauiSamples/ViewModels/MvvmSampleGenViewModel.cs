using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace MauiSamples.ViewModels;

[ObservableObject]
public partial class MvvmSampleGenViewModel
{
    public delegate void PrintAddressDelegate(string address);
    public PrintAddressDelegate OnPrintAddress = null;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullAddress))]
    private string _firstName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullAddress))]
    private string _lastName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullAddress))]
    private string _streetAddress;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullAddress))]
    private string _postCode;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullAddress))]
    private string _city;

    public string FullAddress
    {
        get
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"{FirstName} {LastName}")
                .AppendLine(StreetAddress)
                .AppendLine($"{PostCode} {City}");

            return stringBuilder.ToString();
        }
    }

    [RelayCommand]
    private void ShowAddress()
    {
        OnPrintAddress?.Invoke(FullAddress);
    }
}