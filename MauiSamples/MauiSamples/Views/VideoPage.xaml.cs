namespace MauiSamples.Views;

public partial class VideoPage : ContentPage
{
	public VideoPage()
	{
		InitializeComponent();
	}

    private void OnPlayPressed(object sender, EventArgs e)
    {
        VideoPlayer.Play();
    }

    private void OnPausePressed(object sender, EventArgs e)
    {
        VideoPlayer.Pause();
    }
}