using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSamples.Models;

public partial class VideoModel(string title, string videoUri) : ObservableObject
{
    public string Title { get; } = title;
    public string VideoUri { get; } = videoUri;

    [ObservableProperty]
    private bool _isPlaying;
}