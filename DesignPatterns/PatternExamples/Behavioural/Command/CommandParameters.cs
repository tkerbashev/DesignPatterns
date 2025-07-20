namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal class CommandParameters
{
    public int VerticalPosition { get; set; }
    public int HorizontalPosition { get; set; }
    public string? Direction { get; set; }
    public int MaxHeight { get; set; }
    public int MaxWidth { get; set; }

    public CommandParameters(ISurface surface)
    {
        MaxHeight = surface.Height;
        MaxWidth = surface.Width;
        VerticalPosition = MaxHeight / 2;
        HorizontalPosition = MaxWidth / 2;
    }
}
