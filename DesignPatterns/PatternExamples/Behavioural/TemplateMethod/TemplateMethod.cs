namespace DesignPatterns.PatternExamples.Behavioural.TemplateMethod;

internal class TemplateMethod: IPatternExample
{
    public void Demonstrate( )
    {
        AlgebraExpert akgebraExpert = new( );
        akgebraExpert.SolveTheProblem( );

        GeometryExpert geometryExpert = new( );
        geometryExpert.SolveTheProblem( );

        SoftwareDeveloper softwareDeveloper = new( );
        softwareDeveloper.SolveTheProblem( );
    }
}