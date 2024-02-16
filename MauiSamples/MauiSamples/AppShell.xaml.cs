using MauiSamples.Views;
using MauiSamples.Views.Accordion;

namespace MauiSamples;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Routing.RegisterRoute(nameof(MultiBindingPage), typeof(MultiBindingPage));
        //Routing.RegisterRoute(nameof(PassObjectsPage), typeof(PassObjectsPage));
        //Routing.RegisterRoute(nameof(AccordionOnePage), typeof(AccordionOnePage));
        //Routing.RegisterRoute(nameof(AccordionMvvmPage), typeof(AccordionMvvmPage));

        //Routing.RegisterRoute(Routes.MultiBindingPage, typeof(MultiBindingPage));
        //Routing.RegisterRoute(Routes.PassObjectsPage, typeof(PassObjectsPage));
        //Routing.RegisterRoute(Routes.AccordionOnePage, typeof(AccordionOnePage));
        //Routing.RegisterRoute(Routes.AccordionMvvmPage, typeof(AccordionMvvmPage));

        foreach (var route in Routes.RouteTypeMap)
        {
            Routing.RegisterRoute(route.Key, route.Value);
        }
    }
}
