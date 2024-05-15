using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSamples.Models;

public partial class VideoModel(string title, string videoUri, Color backgroundColor = default) : ObservableObject
{
    public string Title { get; } = title;
    public string VideoUri { get; } = videoUri;
    public Color BackgroundColor { get; } = backgroundColor ?? Colors.Orange;

    [ObservableProperty]
    private bool _isPlaying;
}