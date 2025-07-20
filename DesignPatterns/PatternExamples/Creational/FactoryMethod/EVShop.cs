namespace DesignPatterns.PatternExamples.Creational.FactoryMethod
{
    abstract class EVShop
    {
        public List<ICar> Inventory { get; } = new List<ICar>();
        public abstract ICar AddCar();
    }
}
