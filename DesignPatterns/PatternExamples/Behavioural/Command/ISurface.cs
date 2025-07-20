namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal interface ISurface
{
    public void Display(string? message);
    public void SetPosition(int horizontal, int vertical);
    public int Width { get; }
    public int Height { get; }
}
