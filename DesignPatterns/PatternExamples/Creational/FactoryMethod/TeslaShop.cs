namespace DesignPatterns.PatternExamples.Creational.FactoryMethod
{
    internal class TeslaShop : EVShop
    {
        public override ICar AddCar( )
        {
            var newCar = new TeslaCar();
            Inventory.Add(newCar);
            return newCar;
        }
    }
}
