namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

internal class Visitor: IPatternExample
{
    public void Demonstrate( )
    {
        List<ICustomer> customers = [ new Office( ), new PrivateHome( ) ];

        PizzaDeliveryService service = new( );
        PizzaDeliverySystem.ListDeliveries( customers, service );
    }
}