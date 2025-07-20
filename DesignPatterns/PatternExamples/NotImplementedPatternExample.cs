using static System.Console;

namespace DesignPatterns.PatternExamples
{
    internal class NotImplementedPatternExample : IPatternExample
    {
        private static readonly Lazy<NotImplementedPatternExample> _instance = new( ( ) => new NotImplementedPatternExample( ) );

        private NotImplementedPatternExample( )
        {
            // Prevent the default public constructor from being created
        }
        public static NotImplementedPatternExample Instance => _instance.Value;

        public void Demonstrate( )
        {
            WriteLine( "The example for this pattern is not yet implemented" );
        }
    }
}
