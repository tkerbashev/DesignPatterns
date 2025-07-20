namespace DesignPatterns.PatternExamples.Creational.Builder
{
    internal class Builder: IPatternExample
    {
        public void Demonstrate( )
        {
            Console.WriteLine( "Building a Bubble Tea" );
            Console.WriteLine( );

            var jacksPurchase = new BubbleTeaPurchase( new RegularBlackMangoHalfIceOrder( ), "Jack" );
            jacksPurchase.MakeTea( );
            jacksPurchase.DescribeTea( );

            Console.WriteLine( );

            var jillsPurchase = new BubbleTeaPurchase( new BigGreenStrawberryFullIceOrder( ), "Jill" );
            jillsPurchase.MakeTea( );
            jillsPurchase.DescribeTea( );
        }
    }
}