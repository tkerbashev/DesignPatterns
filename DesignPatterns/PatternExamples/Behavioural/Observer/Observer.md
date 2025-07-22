# Observer

## Description

Observer pattern is used when there is a one-to-many 
relationship between objects such as if one object 
is modified, its dependent objects are to be notified 
automatically.  The observer pattern falls under 
behavioural pattern category.

## Scenario

In the stock market many players need to be notified
when the price of a stock changes. In our scenario
there are a buyer, a seller, and a market researcher.
The players dynamically subscribe to or unsubscribe
from the service that notifies of price changes.
Only those who are subscribed receive notifications.

## Implementation

```mermaid
classDiagram
    class IPriceChangeListener {
        <<Interface>>
        +ReceivePriceChangeNotification()
    }

    class MarketResearcher {
        +ReceivePriceChangeNotification()
        -_name: String
    }

    class PriceChange {
        +Price: Decimal
    }

    class PriceChangeNotifier {
        +AddObserver()
        +RemoveObserver()
        +Notify()
        -_listeners: List~IPriceChangeListener~
    }

    class StockMarketService {
        +ReactToPriceChange()
        +AddObserver()
        +RemoveObserver()
        +Notify()
    }

    class TraderBuyer {
        +ReceivePriceChangeNotification()
        +MinimumPrice: Decimal
        -_name: String
    }

    class TraderSeller {
        +ReceivePriceChangeNotification()
        +MaximumPrice: Decimal
        -_name: String
    }


    MarketResearcher --|> IPriceChangeListener
    TraderBuyer --|> IPriceChangeListener
    TraderSeller --|> IPriceChangeListener
    StockMarketService --|> PriceChangeNotifier
    IPriceChangeListener --> PriceChange
    MarketResearcher --> PriceChange
    PriceChangeNotifier --> IPriceChangeListener
    PriceChangeNotifier --> PriceChange
    StockMarketService --> IPriceChangeListener
    StockMarketService --> PriceChange
    TraderBuyer --> PriceChange
    TraderSeller --> PriceChange

```
