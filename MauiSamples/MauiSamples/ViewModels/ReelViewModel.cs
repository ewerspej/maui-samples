using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class ReelViewModel : ObservableObject
{
    private const string FrogVideo = "https://github.com/ewerspej/maui-samples/blob/main/assets/frog.mp4?raw=true";
    private const string LakeVideo = "https://github.com/ewerspej/maui-samples/blob/main/assets/lake.mp4?raw=true";

    [ObservableProperty]
    private ObservableCollection<VideoModel> _videos;

    public ReelViewModel()
    {
        Videos =
        [
            new VideoModel("First", FrogVideo),
            new VideoModel("Second", LakeVideo),
            new VideoModel("Third", FrogVideo),
            new VideoModel("Fourth", LakeVideo),
            new VideoModel("Fifth", FrogVideo),
            new VideoModel("Sixth", LakeVideo)
        ];
    }
}