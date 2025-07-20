namespace DesignPatterns.PatternExamples.Creational.Prototype
{
    public abstract class Person
    {
        public abstract string Name { get; }

        public abstract Person Clone();

        public void PresentYourself()
        {
            Console.WriteLine("I am " + Name);
        }
    }
}
