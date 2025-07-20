namespace DesignPatterns.PatternExamples.Structural.Bridge;

internal class Bridge: IPatternExample
{
    public void Demonstrate( )
    {
        var leftHanded = new LeftHanded( );
        var rightHanded = new RightHanded( );

        var rightHandedFemale = new FemalePlayer( rightHanded );
        var leftHandedMale = new MalePlayer( leftHanded );

        Console.WriteLine( "And here on the stage are the stars of our tournament:" );
        Console.WriteLine( rightHandedFemale.DescribePlayer( ) );
        Console.WriteLine( leftHandedMale.DescribePlayer( ) );
    }
}