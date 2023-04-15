using MauiSamples.Graphics.Drawables;

namespace MauiSamples.Graphics;

public class SampleGraphicsView : GraphicsView
{
    public double Radius
    {
        get => (double)GetValue(RadiusProperty);
        set => SetValue(RadiusProperty, value);
    }

    public static readonly BindableProperty RadiusProperty = BindableProperty.Create(nameof(Radius), typeof(double), typeof(SampleGraphicsView), propertyChanged: RadiusPropertyChanged);

    private static void RadiusPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not SampleGraphicsView { Drawable: CircleDrawable drawable } view)
        {
            return;
        }

        drawable.Radius = (double)newValue;
        view.Invalidate();
    }
}