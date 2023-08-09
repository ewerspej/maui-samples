using epj.Expander.Maui;

namespace MauiSamples.Views.Accordion;

public partial class AccordionOnePage : ContentPage
{
	public AccordionOnePage()
	{
		InitializeComponent();
	}

    private void Expander_OnHeaderTapped(object sender, ExpandedEventArgs e)
    {
        if (sender is not Expander expander)
        {
            return;
        }

        foreach (var child in AccordionLayout.Children)
        {
            if (child is not Expander other)
            {
                continue;
            }

            if (other != expander)
            {
                other.IsExpanded = false;
            }
        }
    }
}