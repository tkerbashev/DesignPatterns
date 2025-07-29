using DesignPatterns.PatternExamples;

namespace DesignPatterns.Menu;

internal class MenuItem : IMenuItem
{
    private readonly List<IMenuItem> _children = [ ];
    private IMenuItem? _parent;

    public IMenuItem? Parent 
    { 
        get
        {
            return _parent;
        }
        init
        {
            if (value is not null)
            {
                _parent = value;
                _parent.AddChild( this );
            }
        }
    }

    public IMenuItem[ ] Children => [ .. _children ];
    public void AddChild( IMenuItem child )
    {
        _children.Add( child );
    }

    public required string Text { get; internal init; }

    public string Title
    {
        get
        {
            return string.Join( "/", GetTexts( this, []).ToArray() );
        }
    }

    private static List<string> GetTexts( IMenuItem menuItem, List<string> currentList )
    {
        if ( menuItem is null )
        {
            return currentList;
        }

        if ( menuItem.Parent is null )
        {
            currentList.Add( menuItem.Text );
            return currentList;
        }
        else
        {
            currentList = GetTexts( menuItem.Parent, currentList );
            currentList.Add( menuItem.Text );
            return currentList;
        }
    }

    public IMenuItemStrategy Strategy { get; internal set; } = Menu.PatternExample.Instance;
    public void Demonstrate() => Strategy.Demonstrate( this );

    public IPatternExample PatternExample { get; internal set; } =  NotImplementedPatternExample.Instance;
}
