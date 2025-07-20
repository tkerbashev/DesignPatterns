namespace DesignPatterns.PatternExamples.Behavioural.Command;

internal class PositionTracker
{
    ILogger logger = new Logger();
    ISurface surface = new Surface();

    private List<MoveCommand> moveCommands = new List<MoveCommand>();

    public PositionTracker(ILogger logger, ISurface surface)
    {
        this.logger = logger;
        this.surface = surface;

        surface.SetPosition(surface.Width / 2, surface.Height / 2);
    }

    public MoveCommand AddCommand(ConsoleKeyInfo keyInfo)
    {
        var command = new MoveCommand(keyInfo);
        moveCommands.Add(command);
        return command;
    }

    public void ListExecutedCommands()
    {
        logger.Log("Your moves were:");
        CommandParameters parameters = new (surface);
        int counter = 1;
        foreach (MoveCommand command in moveCommands) 
        {
            command.Execute(parameters);
            if (!string.IsNullOrEmpty(parameters.Direction))
            {
                logger.Log(counter.ToString("###") + ": " + $"{MoveCommand.TranslateDirection(parameters.Direction)}");
            }
            counter++;
        }
    }

    public void DisplayMovement(MoveCommand command, CommandParameters parameters)
    {
        command.Execute(parameters);
        surface.Display(parameters.Direction);
        surface.SetPosition(parameters.HorizontalPosition, parameters.VerticalPosition);
    }

}
