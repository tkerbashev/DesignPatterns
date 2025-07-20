namespace DesignPatterns.PatternExamples.Structural.Proxy;

public class TVColtroller : ITVController
{
    public void ChannelDown( )
    {
        Console.WriteLine( "Go to the previous channel" );
    }

    public void ChannelUp( )
    {
        Console.WriteLine( "Go to the next channel" );
    }

    public void Start( )
    {
        Console.WriteLine( "Start the TV" );
    }

    public void Stop( )
    {
        Console.WriteLine( "Stop the TV" );
    }

    public void VolumeDown( )
    {
        Console.WriteLine( "Decrease the volume" );
    }

    public void VolumeUp( )
    {
        Console.WriteLine( "Increase the volume" );
    }
}
