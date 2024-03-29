﻿using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PropertyChangingEventArgs = System.ComponentModel.PropertyChangingEventArgs;
using PropertyChangingEventHandler = System.ComponentModel.PropertyChangingEventHandler;

namespace MauiSamples.ViewModels;

public sealed class AddressViewModel : INotifyPropertyChanged, INotifyPropertyChanging
{
    #region Delegates

    public delegate void PrintAddressDelegate(string address);
    public PrintAddressDelegate OnPrintAddress = null;

    #endregion

    #region Commands

    private IAsyncRelayCommand _printAddressCommand;
    public IAsyncRelayCommand PrintAddressCommand => _printAddressCommand ??= new AsyncRelayCommand<string>(PrintAddressAsync, canExecute: CanPrint);

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
                OnPropertyChanged(nameof(FullAddress));
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
                OnPropertyChanged(nameof(FullAddress));
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
                OnPropertyChanged(nameof(FullAddress));
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
                OnPropertyChanged(nameof(FullAddress));
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
                OnPropertyChanged(nameof(FullAddress));
            }
        }
    }

    private int _copies;
    public int Copies
    {
        get => _copies;
        set
        {
            if (value == _copies)
            {
                return;
            }

            //do something before property is changing
            Console.WriteLine($"Property {nameof(Copies)} is about to change. " +
                              $"Current value: {Copies}, new value: {value}");
            OnPropertyChanging();

            _copies = value;

            //do something after property changed
            Console.WriteLine($"Property {nameof(Copies)} has changed. " +
                              $"Current value: {Copies}, new value: {value}");
            OnPropertyChanged();

            PrintAddressCommand.NotifyCanExecuteChanged();
        }
    }

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

    private bool _isBusy;
    public bool IsBusy
    {
        get => _isBusy;
        set => SetField(ref _isBusy, value);
    }

    #endregion

    #region Private Methods

    private async Task PrintAddressAsync(string address)
    {
        IsBusy = true;

        await PrintAsync(address);

        IsBusy = false;
    }

    private async Task PrintAsync(string address)
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        OnPrintAddress?.Invoke(address);
    }

    private bool CanPrint(string address) => Copies > 0 && !string.IsNullOrWhiteSpace(address);

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

    #region INotifyPropertyChanging implementation

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanging([CallerMemberName] string propertyName = null)
    {
        PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
    }

    #endregion
}