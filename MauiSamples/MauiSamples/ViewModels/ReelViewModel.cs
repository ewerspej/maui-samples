using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class ReelViewModel : ObservableObject
{
    private const string FrogVideo = "https://github.com/ewerspej/maui-samples/blob/main/assets/frog.mp4?raw=true";
    private const string BuckVideo = "https://github.com/ewerspej/maui-samples/blob/main/assets/bigbuckbunny.mp4?raw=true";

    [ObservableProperty]
    private ObservableCollection<VideoModel> _videos;

    public ReelViewModel()
    {
        Videos =
        [
            new VideoModel("First", FrogVideo, Colors.Aqua),
            new VideoModel("Second", BuckVideo, Colors.Red),
            new VideoModel("Third", FrogVideo, Colors.GreenYellow),
            new VideoModel("Fourth", BuckVideo, Colors.DarkSlateGray),
            new VideoModel("Fifth", FrogVideo, Colors.DeepSkyBlue),
            new VideoModel("Sixth", BuckVideo, Colors.Orange)
        ];
    }
}