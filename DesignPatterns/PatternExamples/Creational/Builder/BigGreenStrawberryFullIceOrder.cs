namespace DesignPatterns.PatternExamples.Creational.Builder
{
    internal class BigGreenStrawberryFullIceOrder : BubbleTeaOrder
    {
        public override void DetermineBubbles( )
        {
            BubbleTea.AddFeature( "Strawberry bubbles" );
        }

        public override void DetermineIce( )
        {
            BubbleTea.AddFeature( "Full Ice" );
        }

        public override void DetermineSize( )
        {
            BubbleTea.AddFeature( "Large" );
        }

        public override void DetermineTea( )
        {
            BubbleTea.AddFeature( "Green Tea" );
        }
    }
}
