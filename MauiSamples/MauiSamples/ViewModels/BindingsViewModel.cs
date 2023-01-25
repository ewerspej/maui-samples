using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Models;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class BindingsViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<BindingItem> _items = new();

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
    private void RemoveItem(BindingItem item = null)
    {
        if (Items.Count == 0)
        {
            return;
        }

        if (item == null)
        {
            Items.Remove(Items.Last());
            return;
        }

        Items.Remove(item);
    }
}