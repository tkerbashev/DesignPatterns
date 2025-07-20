namespace DesignPatterns.PatternExamples.Structural.Composite;

public abstract class Article
{
    public string Author { get; set; }

    public abstract int GetNumberOfPages();

    public Article(string author)
    {
        Author = author;
    }
}
