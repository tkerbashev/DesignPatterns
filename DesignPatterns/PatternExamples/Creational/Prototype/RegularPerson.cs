namespace DesignPatterns.PatternExamples.Creational.Prototype
{
    public class RegularPerson : Person
    {
        public override string Name { get; }

        public RegularPerson(string name) 
        {
            Name = name;
        }

        public override Person Clone( )
        {
            return (Person)MemberwiseClone( );
        }
    }
}
