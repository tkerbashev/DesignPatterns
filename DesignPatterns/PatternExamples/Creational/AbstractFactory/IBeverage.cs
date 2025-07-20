namespace DesignPatterns.PatternExamples.Creational.AbstractFactory
{
    public interface IBeverage
    {
        IBeverageService PrepareBeverageService();
        IDrinkwareService PrepareDrinkwareService();
    }
}
