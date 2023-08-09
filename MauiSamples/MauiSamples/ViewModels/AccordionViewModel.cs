using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSamples.Models;

namespace MauiSamples.ViewModels;

public partial class AccordionViewModel : ObservableObject
{
    [ObservableProperty]
    private List<AccordionItem> _items;

    public AccordionViewModel()
    {
        Items = new List<AccordionItem>
        {
            new()
            {
                Name = "John",
                Description = "Rockstar"
            },
            new()
            {
                Name = "Jim",
                Description = "Rain Man"
            },
            new()
            {
                Name = "Jack",
                Description = "Programmer"
            }
        };
    }

    [RelayCommand]
    private void SelectItem(AccordionItem item)
    {
        item.Selected = !item.Selected;

        foreach (var accordionItem in Items.Where(accordionItem => accordionItem != item))
        {
            accordionItem.Selected = false;
        }
    }
}