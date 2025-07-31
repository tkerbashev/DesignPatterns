namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal class BakeCookies
    {
        public static int BakeCookiesInTheOven(int numberOfCookiesBaked)
        {
            Console.WriteLine( $"Baking {numberOfCookiesBaked} yammy cookies in the oven" );
            return numberOfCookiesBaked;
        }

        public static void StoreCookies( int numberOfCookiesBaked, CookieRepositoryBase cookieRepository )
        {
            Console.WriteLine( $"Counting {numberOfCookiesBaked} cookies, baked in the oven" );
            cookieRepository.AddCookies( numberOfCookiesBaked );
        }
    }
}
