using DesignPatterns.PatternExamples.Creational.Singleton;
using DesignPatterns.PatternExamples.Creational.Builder;
using DesignPatterns.PatternExamples.Creational.AbstractFactory;
using DesignPatterns.PatternExamples.Creational.FactoryMethod;
using DesignPatterns.PatternExamples.Creational.Prototype;
using DesignPatterns.PatternExamples.Structural.Adaptor;
using DesignPatterns.PatternExamples.Structural.Bridge;
using DesignPatterns.PatternExamples.Structural.Composite;
using DesignPatterns.PatternExamples.Structural.Decorator;
using DesignPatterns.PatternExamples.Structural.Facade;
using DesignPatterns.PatternExamples.Structural.Flyweight;
using DesignPatterns.PatternExamples.Structural.Proxy;
using DesignPatterns.PatternExamples.Behavioural.ChainOfResponsibility;
using DesignPatterns.PatternExamples.Behavioural.Command;
using DesignPatterns.PatternExamples.Behavioural.Interpreter;
using DesignPatterns.PatternExamples.Behavioural.Iterator;
using DesignPatterns.PatternExamples.Behavioural.Mediator;
using DesignPatterns.PatternExamples.Behavioural.Memento;
using DesignPatterns.PatternExamples.Behavioural.Observer;
using DesignPatterns.PatternExamples.Behavioural.State;
using DesignPatterns.PatternExamples.Behavioural.Strategy;
using DesignPatterns.PatternExamples.Behavioural.TemplateMethod;
using DesignPatterns.PatternExamples.Behavioural.Visitor;
using DesignPatterns.PatternExamples.Behavioural.NullObject;
using DesignPatterns.PatternExamples.Miscellaneous.UnitOfWork;

namespace DesignPatterns.Menu;

internal class MenuLoader
{
    private static readonly Lazy<Singleton> _singleton = new( ( ) => new Singleton( ) );
    private static readonly Lazy<Builder> _builder = new( ( ) => new Builder( ) );
    private static readonly Lazy<AbstractFactory> _abstractFactory = new( ( ) => new AbstractFactory( ) );
    private static readonly Lazy<FactoryMethod> _factoryMethod = new( ( ) => new FactoryMethod( ) );
    private static readonly Lazy<Prototype> _prototype = new( ( ) => new Prototype( ) );

    private static readonly Lazy<Adaptor> _adaptor = new( ( ) => new Adaptor( ) );
    private static readonly Lazy<Bridge> _bridge = new( ( ) => new Bridge( ) );
    private static readonly Lazy<Composite> _composite = new( ( ) => new Composite( ) );
    private static readonly Lazy<Decorator> _decorator = new( ( ) => new Decorator( ) );
    private static readonly Lazy<Facade> _facade = new( ( ) => new Facade( ) );
    private static readonly Lazy<Flyweight> _flyweight = new( ( ) => new Flyweight( ) );
    private static readonly Lazy<Proxy> _proxy = new( ( ) => new Proxy( ) );

    private static readonly Lazy<ChainOfResponsibility> _chainOfResponsibility = new( ( ) => new ChainOfResponsibility( ) );
    private static readonly Lazy<Command> _command = new( ( ) => new Command( ) );
    private static readonly Lazy<Interpreter> _interpreter = new( ( ) => new Interpreter( ) );
    private static readonly Lazy<Iterator> _iterator = new( ( ) => new Iterator( ) );
    private static readonly Lazy<Mediator> _mediator = new( ( ) => new Mediator( ) );
    private static readonly Lazy<Memento> _memento = new( ( ) => new Memento( ) );
    private static readonly Lazy<Observer> _observer = new( ( ) => new Observer( ) );
    private static readonly Lazy<State> _state = new( ( ) => new State( ) );
    private static readonly Lazy<Strategy> _strategy = new( ( ) => new Strategy( ) );
    private static readonly Lazy<TemplateMethod> _templateMethod = new( ( ) => new TemplateMethod( ) );
    private static readonly Lazy<Visitor> _visitor = new( ( ) => new Visitor( ) );
    private static readonly Lazy<NullObject> _nullObject = new( ( ) => new NullObject( ) );
    private static readonly Lazy<UnitOfWork> _unitOfWork = new( ( ) => new UnitOfWork( ) );

    public static IMenuItem Load( )
    {
        var subMenu = new SubMenu( );

        MenuItem designPatternsMenu = new( ) { Text = "Design Patterns", Parent = null, Strategy = subMenu };

        MenuItem behavioural = new( ) { Text = "Behavioural", Parent = designPatternsMenu, Strategy = subMenu };
        _ = new MenuItem( ) { Text = "Chain of Responsibility", Parent = behavioural, PatternExample = _chainOfResponsibility.Value };
        _ = new MenuItem( ) { Text = "Command", Parent = behavioural, PatternExample = _command.Value };
        _ = new MenuItem( ) { Text = "Interpretter", Parent = behavioural, PatternExample = _interpreter.Value };
        _ = new MenuItem( ) { Text = "Iterator", Parent = behavioural, PatternExample = _iterator.Value };
        _ = new MenuItem( ) { Text = "Mediator", Parent = behavioural, PatternExample = _mediator.Value };
        _ = new MenuItem( ) { Text = "Memento", Parent = behavioural, PatternExample = _memento.Value };
        _ = new MenuItem( ) { Text = "Observer", Parent = behavioural, PatternExample = _observer.Value };
        _ = new MenuItem( ) { Text = "State", Parent = behavioural, PatternExample = _state.Value };
        _ = new MenuItem( ) { Text = "Strategy", Parent = behavioural, PatternExample = _strategy.Value };
        _ = new MenuItem( ) { Text = "Template Method", Parent = behavioural, PatternExample = _templateMethod.Value };
        _ = new MenuItem( ) { Text = "Visitor", Parent = behavioural, PatternExample = _visitor.Value };

        MenuItem creational = new( ) { Text = "Creational", Parent = designPatternsMenu, Strategy = subMenu };
        _ = new MenuItem( ) { Text = "Abstract Factory", Parent = creational, PatternExample = _abstractFactory.Value };
        _ = new MenuItem( ) { Text = "Builder", Parent = creational, PatternExample = _builder.Value };
        _ = new MenuItem( ) { Text = "FactoryMethod", Parent = creational, PatternExample = _factoryMethod.Value };
        _ = new MenuItem( ) { Text = "Prototype", Parent = creational, PatternExample = _prototype.Value };
        _ = new MenuItem( ) { Text = "Singleton", Parent = creational, PatternExample = _singleton.Value };

        MenuItem structural = new( ) { Text = "Structural", Parent = designPatternsMenu, Strategy = subMenu };
        _ = new MenuItem( ) { Text = "Adaptor", Parent = structural, PatternExample = _adaptor.Value };
        _ = new MenuItem( ) { Text = "Bridge", Parent = structural, PatternExample = _bridge.Value };
        _ = new MenuItem( ) { Text = "Composite", Parent = structural, PatternExample = _composite.Value };
        _ = new MenuItem( ) { Text = "Decorator", Parent = structural, PatternExample = _decorator.Value };
        _ = new MenuItem( ) { Text = "Facade", Parent = structural, PatternExample = _facade.Value };
        _ = new MenuItem( ) { Text = "Flyweight", Parent = structural, PatternExample = _flyweight.Value };
        _ = new MenuItem( ) { Text = "Proxy", Parent = structural, PatternExample = _proxy.Value };
        _ = new MenuItem( ) { Text = "Null Object", Parent = behavioural, PatternExample = _nullObject.Value };

        MenuItem miscellaneous = new( ) { Text = "Miscellaneous", Parent = designPatternsMenu, Strategy = subMenu };
        _ = new MenuItem( ) { Text = "Repository", Parent = miscellaneous };
        _ = new MenuItem( ) { Text = "Unit of Work", Parent = miscellaneous, PatternExample = _unitOfWork.Value };

        return designPatternsMenu;
    }
}
