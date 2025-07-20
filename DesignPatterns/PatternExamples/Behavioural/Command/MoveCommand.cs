namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal class MoveCommand
{
    private ConsoleKeyInfo keyInfo;

    public MoveCommand(ConsoleKeyInfo keyInfo)
    {
        this.keyInfo = keyInfo;
    }

    public void Execute(CommandParameters parameters)
    {
        parameters.Direction = string.Empty;
        if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            if (parameters.VerticalPosition > 0)
            {
                parameters.VerticalPosition--;
            }
            parameters.Direction = "u";
            return;
        }

        if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            if (parameters.VerticalPosition < parameters.MaxHeight - 1)
            {
                parameters.VerticalPosition++;
            }
            parameters.Direction = "d";
            return;
        }

        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            if (parameters.HorizontalPosition > 0)
            {
                parameters.HorizontalPosition--;
            }
            parameters.Direction = "l";
            return;
        }

        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            if (parameters.HorizontalPosition < parameters.MaxWidth - 1)
            {
                parameters.HorizontalPosition++;
            }
            parameters.Direction = "r";
            return;
        }
    }

    public static string TranslateDirection(string? direction)
    {
        if (string.IsNullOrEmpty(direction))
            return string.Empty;

        return direction switch
        {
            "u" => "up",
            "l" => "left",
            "r" => "right",
            "d" => "down",
            _ => string.Empty,
        };
    }
}
