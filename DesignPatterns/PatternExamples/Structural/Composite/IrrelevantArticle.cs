namespace DesignPatterns.PatternExamples.Structural.Composite;

public class IrrelevantArticle : Article
{
    private readonly int _numberOfPages;
    public IrrelevantArticle(string author, int numberOfPages ) : base(author) 
    {
        _numberOfPages = numberOfPages;
    }

    public override int GetNumberOfPages( )
    {
        return _numberOfPages;
    }
}
