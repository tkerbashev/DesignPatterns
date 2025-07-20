namespace DesignPatterns.PatternExamples.Creational.Prototype;

internal class Prototype: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Prototype Creational Design Pattern example\n" );

        Console.WriteLine( "(This is the most basic implementation using a shallow copy)\n" );

        var characters = new List<Person>( );

        Person agentSmith = new AgentSmith( );
        characters.Add( agentSmith );

        Person agent2 = agentSmith.Clone( );
        characters.Add( agent2 );

        Person agent3 = agentSmith.Clone( );
        characters.Add( agent3 );

        Person john = new RegularPerson( "John" );
        characters.Add( john );

        Person mary = new RegularPerson( "Mary" );
        characters.Add( mary );

        foreach (Person person in characters)
        {
            person.PresentYourself( );
        }
    }
}