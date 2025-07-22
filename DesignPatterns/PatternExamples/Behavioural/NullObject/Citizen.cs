namespace DesignPatterns.PatternExamples.Behavioural.NullObject;

internal class Citizen( string name ) : ICitizen
{
    public string Name { get; private init; } = name;
    public IParty PreferredParty { get; init; } = new NoParty();

    public void Declare( )
    {
        Console.WriteLine( $"{Name} says: {PreferredParty.Position}" );
    }
}
