using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Models;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class BindingsViewModel : ObservableObject
{
    public Func<object, bool> IsPrimeFunc => IsPrime;

    [ObservableProperty]
    private ObservableCollection<BindingItem> _items = [];

    private int _counter = 0;

    [RelayCommand]
    private void AddItem()
    {
        Items.Add(new BindingItem
        {
            Name = $"Item {_counter}",
            Count = _counter
        });

        _counter++;
    }

    [RelayCommand]
    private void RemoveItem(BindingItem? item = null)
    {
        if (Items.Count == 0)
        {
            return;
        }

        if (item is null)
        {
            Items.Remove(Items.Last());
            return;
        }

        Items.Remove(item);
    }

    private static bool IsPrime(object number)
    {
        if (number is not int intNumber || intNumber < 2)
        {
            return false;
        }

        for (var i = 2; i <= Math.Sqrt(intNumber); i++)
        {
            if (intNumber % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}