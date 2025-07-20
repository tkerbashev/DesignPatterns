namespace DesignPatterns.PatternExamples.Structural.Adaptor;

internal class Adaptor: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Two versions of the Adaptor Structural Design Pattern implementation\n" );
        Console.WriteLine( );


        // First, the object Adaptor variant
        var legacyObject = new LegacyClass( );
        var objectAdaptorClient = new Client( new LoginAdaptorObject( legacyObject ) );
        objectAdaptorClient.PerformLogin( );

        Console.WriteLine( );

        // Second, the class adaptor variant
        var classAdaptorClient = new Client( new LoginAdaptorClass( ) );
        classAdaptorClient.PerformLogin( );
    }
}