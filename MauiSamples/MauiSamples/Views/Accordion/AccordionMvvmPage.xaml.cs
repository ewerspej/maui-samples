using MauiSamples.ViewModels;

namespace MauiSamples.Views.Accordion;

public partial class AccordionMvvmPage : ContentPage
{
    public AccordionMvvmPage()
    {
        InitializeComponent();
        BindingContext = new AccordionViewModel();
    }
}