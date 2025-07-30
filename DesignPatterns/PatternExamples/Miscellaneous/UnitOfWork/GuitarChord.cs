using static System.Console;

namespace DesignPatterns.PatternExamples.Miscellaneous.UnitOfWork
{
    internal class GuitarChord( string Name, HashSet<FingerOnString> ExpectedFingerPlacements )
    {
        private readonly HashSet<FingerOnString> _fingers = [];

        public void PlaceFingerOnNeck ( FingerOnString fingerOnString )
        {
            WriteLine( $"Placing finger {fingerOnString.Finger} on string {fingerOnString.StringNumber} near fret {fingerOnString.FretNumber}" );
            _fingers.Add( fingerOnString );
        }

        public void LiftFingerFromNeck( FingerOnString fingerOnString )
        {
            WriteLine( $"Lifting the finger {fingerOnString.Finger} on string {fingerOnString.StringNumber} near fret {fingerOnString.FretNumber}" );
            _fingers.Remove( fingerOnString );
        }

        public void Strum( )
        {
            WriteLine( );
            if (_fingers.SetEquals( ExpectedFingerPlacements ))
            {
                WriteLine( $"Playing the chord {Name}. Bravo! It sounds beautiful!" );
            }
            else
            {
                WriteLine( "Please check again how the chord needs to be played!" );
                WriteLine( );
            }
        }

    }
}
