namespace DesignPatterns.PatternExamples.Creational.AbstractFactory
{
    internal class TeaFactory : IBeverage
    {
        public IBeverageService PrepareBeverageService( )
        {
            return new TeaService( );
        }

        public IDrinkwareService PrepareDrinkwareService( )
        {
            return new TeaCupService();
        }
    }
}
