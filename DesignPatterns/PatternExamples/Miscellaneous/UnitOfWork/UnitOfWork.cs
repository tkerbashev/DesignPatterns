namespace DesignPatterns.PatternExamples.Miscellaneous.UnitOfWork
{
    internal class UnitOfWork : IPatternExample
    {
        public void Demonstrate( )
        {
            var fingerPlacementForEm = new HashSet<FingerOnString>() { new( 5, 2, '2' ), new( 4, 2, '3' ) };

            var em = new GuitarChord( "Em", fingerPlacementForEm);

            em.PlaceFingerOnNeck( new FingerOnString( 5, 1, '2'));
            em.PlaceFingerOnNeck( new FingerOnString( 4, 2, '3' ) );
            em.Strum();

            em.LiftFingerFromNeck( new FingerOnString( 5, 1, '2'));
            em.PlaceFingerOnNeck( new FingerOnString( 5, 2, '2' ) );
            em.Strum();
        }
    }
}
