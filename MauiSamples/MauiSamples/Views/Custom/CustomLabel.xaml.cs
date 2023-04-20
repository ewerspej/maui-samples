namespace MauiSamples.Views.Custom;

public partial class CustomLabel : ContentView
{
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomLabel));

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomLabel), propertyChanged: OnTextColorPropertyChanged);

    private static void OnTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((CustomLabel)bindable).TextLabel.TextColor = (Color)newValue;
    }

    public CustomLabel()
    {
        InitializeComponent();
        
        TextLabel.SetAppThemeColor(Label.TextColorProperty, Colors.Blue, Colors.White);
    }
}