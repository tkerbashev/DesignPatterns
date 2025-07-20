namespace DesignPatterns.PatternExamples.Structural.Composite;

internal class Composite: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Composite Structural Design Pattern example\n" );

        var adamsArticle = new RelevantArticle( "Prof Adams", 17 );
        var burnsArticle = new RelevantArticle( "Dr Burns", 12 );
        var clydeArticle = new IrrelevantArticle( "Prof Clyde", 26 );
        var dexterArticle = new RelevantArticle( "Dr Dexter", 11 );
        var emmetArticle = new IrrelevantArticle( "Dr Emmet", 9 );

        adamsArticle.Add( burnsArticle );
        adamsArticle.Add( clydeArticle );
        burnsArticle.Add( dexterArticle );
        burnsArticle.Add( emmetArticle );

        Console.WriteLine( "In order to properly research the assigned problem you need to read and analyse " + adamsArticle.GetNumberOfPages( ).ToString( ) + " pages" );
    }
}