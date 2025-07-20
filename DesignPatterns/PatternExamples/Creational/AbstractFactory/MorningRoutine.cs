namespace DesignPatterns.PatternExamples.Creational.AbstractFactory
{
    public class MorningRoutine
    {
        private readonly IBeverageService _beverageService;
        private readonly IDrinkwareService _drinkwareService;

        public MorningRoutine(IBeverage factory)
        {
            _beverageService = factory.PrepareBeverageService();
            _drinkwareService = factory.PrepareDrinkwareService();
        }

        public void Drink()
        {
            Console.WriteLine("Having my " + _beverageService.BeverageType + " in that wondeful " + _drinkwareService.GlassType);
        }
    }
}
