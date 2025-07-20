namespace DesignPatterns.PatternExamples.Behavioural.Interpreter;

public interface ISQLExpression
{
    void Interpret( SQLContext context );
}
