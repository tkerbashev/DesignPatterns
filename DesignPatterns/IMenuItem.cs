using DesignPatterns.PatternExamples;

namespace DesignPatterns;

internal interface IMenuItem
{
    IMenuItem? Parent { get; }
    IMenuItem[ ] Children { get; }
    void AddChild( IMenuItem child );
    IPatternExample PatternExample { get; }
    string Text { get; }
    string Title { get; }
    IMenuItemStrategy Strategy { get; }
    void Demonstrate();
}
