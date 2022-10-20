namespace MauiSamples.Models;

public sealed class Theme
{
    public static Theme Dark = new(0, nameof(Dark), "Night Mode");
    public static Theme Light = new(1, nameof(Light), "Day Mode");
    public static Theme System = new(2, nameof(System), "Follow System");

    public int Id { get; }
    public string Name { get; }
    public string DisplayName { get; }

    private Theme(int id, string name, string displayName)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
    }
}