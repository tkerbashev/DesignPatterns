namespace DesignPatterns.PatternExamples.Creational.Builder
{
    public abstract class BubbleTeaOrder
    {
        public BubbleTea BubbleTea { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public BubbleTeaOrder()
        {
            BubbleTea = new BubbleTea();
        }

        public abstract void DetermineSize();
        public abstract void DetermineTea( );
        public abstract void DetermineBubbles( );
        public abstract void DetermineIce( );
    }
}
