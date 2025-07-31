namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal class Repository : IPatternExample
    {
        public void Demonstrate( )
        {
            BigGlassJar glassJarInTheKitchen = new( "Big glass jar in the kitchen" );
            FancyPlasticBox plasticBoxInTheCupboard = new( "Fancy plastic box in the cupboard" );

            var cookiesFromTheShop = GroceryShopping.BuyCookies( 16 );
            GroceryShopping.StoreCookies( cookiesFromTheShop, plasticBoxInTheCupboard );
            Console.WriteLine();

            var cookiesFromTheOven = BakeCookies.BakeCookiesInTheOven( 24 );
            BakeCookies.StoreCookies( 10, glassJarInTheKitchen );
            BakeCookies.StoreCookies( cookiesFromTheOven - 10, glassJarInTheKitchen );
            Console.WriteLine( );

            // Time to have some of the cookies
            glassJarInTheKitchen.TakeACookie();
            glassJarInTheKitchen.TakeACookie( );
            glassJarInTheKitchen.TakeACookie( );
            Console.WriteLine( );

            plasticBoxInTheCupboard.TakeACookie( );
            plasticBoxInTheCupboard.TakeACookie( );
        }
    }
}
