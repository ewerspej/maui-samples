namespace MauiSamples;

public static class Messages
{
    public static async Task SayHello(this Page page)
    {
        await page.DisplayAlert("Hello", "Hello from Android!", "OK");
    }
}