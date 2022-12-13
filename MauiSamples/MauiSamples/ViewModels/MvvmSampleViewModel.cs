using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace MauiSamples.ViewModels;

public sealed class MvvmSampleViewModel : INotifyPropertyChanged
{
    #region Delegates

    public delegate void DisplayAddressDelegate(string address);
    public DisplayAddressDelegate DisplayAddress = null;

    #endregion

    #region Commands

    private ICommand _showAddressCommand;
    public ICommand ShowAddressCommand => _showAddressCommand ??= new Command(ShowAddress);

    #endregion

    #region Properties

    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (SetField(ref _firstName, value))
            {
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set
        {
            if (SetField(ref _lastName, value))
            {
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    private string _streetAddress;
    public string StreetAddress
    {
        get => _streetAddress;
        set
        {
            if (SetField(ref _streetAddress, value))
            {
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    private string _postCode;
    public string PostCode
    {
        get => _postCode;
        set
        {
            if (SetField(ref _postCode, value))
            {
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    private string _city;
    public string City
    {
        get => _city;
        set
        {
            if (SetField(ref _city, value))
            {
                OnPropertyChanged(nameof(Address));
            }
        }
    }

    public string Address
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

    #endregion

    #region Private Methods

    private void ShowAddress()
    {
        DisplayAddress?.Invoke(Address);
    }

    #endregion

    #region INotifyPropertyChanged implementation

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}