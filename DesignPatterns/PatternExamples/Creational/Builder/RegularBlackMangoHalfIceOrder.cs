namespace DesignPatterns.PatternExamples.Creational.Builder
{
    internal class RegularBlackMangoHalfIceOrder : BubbleTeaOrder
    {
        public override void DetermineBubbles( )
        {
            BubbleTea.AddFeature("Mango bubbles");
        }

        public override void DetermineIce( )
        {
            BubbleTea.AddFeature("Half Ice");
        }

        public override void DetermineSize( )
        {
            BubbleTea.AddFeature( "Regular" );
        }

        public override void DetermineTea( )
        {
            BubbleTea.AddFeature( "Black Tea" );
        }
    }
}
