namespace DesignPatterns.PatternExamples.Structural.Proxy;

internal class Proxy: IPatternExample
{
    public void Demonstrate( )
    {
        TVColtroller tvController = new( );
        var tvRemote = new TVRemote( tvController );

        Console.WriteLine( "Testing the remote:" );
        tvRemote.Start( );
        tvRemote.ChannelUp( );
        tvRemote.VolumeUp( );
        tvRemote.Stop( );
    }
}