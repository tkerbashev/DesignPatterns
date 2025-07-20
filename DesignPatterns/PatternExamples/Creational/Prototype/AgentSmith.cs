namespace DesignPatterns.PatternExamples.Creational.Prototype
{
    public class AgentSmith : Person
    {
        public override string Name { get; }

        public AgentSmith() 
        {
            Name = "Agent Smith";
        }

        public override Person Clone( )
        {
            return (Person)MemberwiseClone();
        }
    }
}
