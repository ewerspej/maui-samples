using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Models;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class BindingsViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<BindingItem> _items = new();

    [RelayCommand]
    private void AddItem()
    {
        Items.Add(new BindingItem
        {
            Name = $"Item {Items.Count}",
            Count = Items.Count
        });
    }

    [RelayCommand]
    private void RemoveItem()
    {
        if(Items.Count == 0)
        {
            return;
        }

        Items.Remove(Items.Last());
    }
}