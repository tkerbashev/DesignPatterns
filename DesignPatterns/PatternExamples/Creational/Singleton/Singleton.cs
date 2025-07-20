namespace DesignPatterns.PatternExamples.Creational.Singleton;

internal class Singleton: IPatternExample
{
    public void Demonstrate( )
    {
        var scenes = new List<Scene>( ) { new( 5 ), new( 3 ), new( 7 ) };

        var iScene = 1;
        foreach (var scene in scenes)
        {
            Console.WriteLine( "In Scene " + iScene.ToString( ) + " Chuck Norris defeated:" );
            foreach (var guy in scene.BadGuys)
            {
                Console.WriteLine( guy.Name + ", strength " + guy.Strength.ToString( ) );
            }
            Console.WriteLine( );
            iScene++;
        }
    }
}