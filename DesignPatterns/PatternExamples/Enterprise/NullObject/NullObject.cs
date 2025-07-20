namespace DesignPatterns.PatternExamples.Enterprise.NullObject;

internal class NullObject : IPatternExample
{
    public void Demonstrate( )
    {
        List<Citizen> citizens = new();

        var leftParty = new LeftWingParty();
        var rightParty = new RightWingParty();

        citizens.Add( new Citizen( "Adam" ) { PreferredParty = leftParty } );
        citizens.Add( new Citizen( "Bob" ) { PreferredParty = rightParty } );
        citizens.Add( new Citizen( "Charlie" ) { PreferredParty = leftParty } );
        citizens.Add( new Citizen( "David" ) { PreferredParty = rightParty } );
        citizens.Add( new Citizen( "Ethan" ) );

        Console.WriteLine( "Here is what out citizen say:" );
        Console.WriteLine( );
        foreach ( var citizen in citizens )
        {
            citizen.Declare();
        }
    }
}
