namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public class PizzaDeliveryService : IVisitor
{
    public void VisitPrivateHome( ICustomer destination )
    {
        Console.WriteLine($"Delivering pizza to {PrivateHome.Name}");
    }

    public void VisttOffice( ICustomer destination )
    {
        Console.WriteLine( $"Delivering pizza to {Office.Name}" );
    }
}
