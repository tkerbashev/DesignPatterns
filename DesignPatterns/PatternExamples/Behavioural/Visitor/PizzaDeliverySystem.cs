namespace DesignPatterns.PatternExamples.Behavioural.Visitor;

public class PizzaDeliverySystem
{
    public static void ListDeliveries(List<ICustomer> customers, IVisitor visitor)
    {
        foreach (ICustomer customer in customers)
        {
            customer.Accept(visitor);
        }
    }
}
