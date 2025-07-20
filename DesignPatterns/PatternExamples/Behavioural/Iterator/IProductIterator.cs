namespace DesignPatterns.PatternExamples.Behavioural.Iterator;

public interface IProductIterator
{
    Product First();
    Product? Next();
    bool IsFinished { get; }
    Product CurrentProduct { get; }
}
