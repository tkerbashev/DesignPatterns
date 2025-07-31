namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal class GroceryShopping
    {
        public static int BuyCookies( int numberOfCookies )
        {
            Console.WriteLine( $"Buying {numberOfCookies} cookies from the shop" );
            return numberOfCookies;
        }

        public static void StoreCookies( int numberOfCookiesInTheBags, CookieRepositoryBase cookieRepository ) 
        {
            Console.WriteLine( $"Came back from the shop with {numberOfCookiesInTheBags} cookies");
            cookieRepository.AddCookies( numberOfCookiesInTheBags );
        }
    }
}
