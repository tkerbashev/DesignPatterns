namespace DesignPatterns.PatternExamples.Creational.Builder
{
    public class BubbleTeaPurchase
    {
        private BubbleTeaOrder? _order;
        public string Name { get; }

        public BubbleTeaPurchase( BubbleTeaOrder order, string name)
        {
            _order = order;
            Name = name;
        }

        public void MakeTea()
        {
            _order?.DetermineSize();
            _order?.DetermineTea();
            _order?.DetermineBubbles();
            _order?.DetermineIce();
        }

        public void DescribeTea( )
        {
            Console.WriteLine("This is " + Name + "'s tea:");
            _order?.BubbleTea.Describe( );
        }
    }
}
