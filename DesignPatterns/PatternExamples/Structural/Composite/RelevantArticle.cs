namespace DesignPatterns.PatternExamples.Structural.Composite;

public class RelevantArticle : Article
{
    private List<Article> _articles = new List<Article>();
    private readonly int _numberOfPages;

    public RelevantArticle( string author, int numberOfPages ) : base( author )
    {
        _numberOfPages = numberOfPages;
    }

    public void Add( Article article ) 
    {
        _articles.Add( article );
    }

    public void Remove( Article article ) 
    {
        _articles.Remove( article );
    }

    public override int GetNumberOfPages( )
    {
        var totalNumberOfPages = _numberOfPages;
        foreach ( var article in _articles ) 
        {
            totalNumberOfPages += article.GetNumberOfPages();
        }

        return totalNumberOfPages;
    }

}
