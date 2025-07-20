namespace DesignPatterns.PatternExamples.Behavioural.Observer;

public interface IPriceChangeListener
{
    void ReceivePriceChangeNotification( PriceChange priceChange );
}
