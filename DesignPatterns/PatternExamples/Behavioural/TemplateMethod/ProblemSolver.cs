namespace DesignPatterns.PatternExamples.Behavioural.TemplateMethod;

public abstract class ProblemSolver
{
    public virtual void GetTheProblem()
    {
        Console.WriteLine("Reading the problem description from a piece of paper");
    }

    public abstract void SolveTheProblem();

    public void PresentTheSolution()
    {
        Console.WriteLine("Writing the solution to a piece of paper");
    }
}
