namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public class PizzaDeliveryService : IVisitor
{
    public void VisitPrivateHome( PrivateHome destination )
    {
        Console.WriteLine($"Delivering pizza to {PrivateHome.Name}");
    }

    public void VisttOffice( Office destination )
    {
        Console.WriteLine( $"Delivering pizza to {Office.Name}" );
    }
}
