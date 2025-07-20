namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal class Surface : ISurface
{
    public int Width => Console.WindowWidth;

    public int Height => Console.WindowHeight;

    public void Display(string? message)
    {
        Console.Write(message);
    }

    public void SetPosition(int horizontal, int vertical)
    {
        Console.SetCursorPosition(horizontal, vertical);
    }
}
