namespace DesignPatterns.PatternExamples.Creational.Singleton
{
    internal class BadGuy : IFighter
    {
        public string? Name { get; set; }
        public int Strength { get; } 

        public BadGuy(Random rnd)
        {
            Name = "unnamed bad guy";
            Strength = rnd.Next( 0, 10 );
        }
    }
}
