namespace DesignPatterns.PatternExamples.Miscellaneous.Repository
{
    internal abstract class CookieRepositoryBase( string name )
    {
        protected int _numberOfAvailableCookies = 0;
        public void AddCookies( int numberOfNewCookies )
        {
            Console.WriteLine( $"Adding {numberOfNewCookies} cookies to the {name}" );
            _numberOfAvailableCookies += numberOfNewCookies;
        }

        public bool TakeACookie( )
        {
            if (_numberOfAvailableCookies < 1)
            {
                return false;
            }

            Console.WriteLine( $"Taking a delicious cookie from {name}" );
            _numberOfAvailableCookies--;
            return true;
        }

        public abstract bool HasEnoughCookies { get; }
    }
}
