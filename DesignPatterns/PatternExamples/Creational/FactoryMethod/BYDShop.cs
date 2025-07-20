namespace DesignPatterns.PatternExamples.Creational.FactoryMethod
{
    internal class BYDShop : EVShop
    {
        public override ICar AddCar( )
        {
            var newCar = new BYDCar( );
            Inventory.Add( newCar );
            return newCar;
        }
    }
}
