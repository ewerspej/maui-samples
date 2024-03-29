﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace MauiSamples.ViewModels;

public partial class AddressViewModelSourceGen : ObservableObject
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

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(PrintAddressCommand))]
    private int _copies;

    partial void OnCopiesChanging(int value)
    {
        Console.WriteLine($"Property {nameof(Copies)} is about to change. " +
                          $"Current value: {Copies}, new value: {value}");
    }

    partial void OnCopiesChanged(int value)
    {
        Console.WriteLine($"Property {nameof(Copies)} has changed. " +
                          $"Current value: {Copies}, new value: {value}");
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

    [RelayCommand(CanExecute = nameof(CanPrint))]
    private async Task PrintAddressAsync(string address)
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        OnPrintAddress?.Invoke(address);
    }

    private bool CanPrint(string address) => Copies > 0 && !string.IsNullOrWhiteSpace(address);
}