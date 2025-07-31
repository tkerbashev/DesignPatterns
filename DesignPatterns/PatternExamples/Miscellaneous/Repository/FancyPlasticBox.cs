namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal class FancyPlasticBox( string name ) : CookieRepositoryBase( name )
    {
        private const int MINIMUMCOOKIES = 155;
        public override bool HasEnoughCookies
        {
            get
            {
                Console.WriteLine( "Opening the box and looking inside to see if there are enough cookies" );
                return _numberOfAvailableCookies > MINIMUMCOOKIES;
            }
        }
    }
}
