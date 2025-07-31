namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal class BigGlassJar( string name ) : CookieRepositoryBase( name )
    {
        private const int MINIMUMCOOKIES = 10;
        public override bool HasEnoughCookies
        {
            get
            {
                Console.WriteLine( "Looking at the jar to see if there are enough cookies inside" );
                return _numberOfAvailableCookies > MINIMUMCOOKIES;
            }
        }
    }
}
