namespace MauiSamples.Models;

public sealed class Theme
{
    public static Theme Dark = new(0, nameof(Dark));
    public static Theme Light = new(1, nameof(Light));
    public static Theme System = new(2, nameof(System));

    public int Id { get; }
    public string Name { get; }

    private Theme(int id, string name)
    {
        Id = id;
        Name = name;
    }
}