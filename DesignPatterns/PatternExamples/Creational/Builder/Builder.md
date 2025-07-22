# Builder

## Description

The builder pattern is a creational design pattern 
that allows for the step-by-step creation of complex 
objects.

## Scenario

We are running a bubble tea shop. The customers have
different preferences - what cup size, what tea,
what bubbles and how much ice, but the procedure of
preparing the product is the same. We have a couple 
of clases with favourite combinations, both
inheriting from BubbleTeaOrder and use them when an
order is placed.

## Implementation

```mermaid
classDiagram
    class BigGreenStrawberryFullIceOrder {
        +DetermineBubbles()
        +DetermineIce()
        +DetermineSize()
        +DetermineTea()
        +BubbleTea: BubbleTea
        +Name: String
    }

    class BubbleTea {
        +Describe()
        +AddFeature()
        -_features: List~String~
    }

    class BubbleTeaOrder {
        +DetermineSize()
        +DetermineTea()
        +DetermineBubbles()
        +DetermineIce()
        +BubbleTea: BubbleTea
        +Name: String
    }

    class BubbleTeaPurchase {
        +MakeTea()
        +DescribeTea()
        +Name: String
        -_order: BubbleTeaOrder
    }

    class RegularBlackMangoHalfIceOrder {
        +DetermineBubbles()
        +DetermineIce()
        +DetermineSize()
        +DetermineTea()
        +BubbleTea: BubbleTea
        +Name: String
    }


    BigGreenStrawberryFullIceOrder --|> BubbleTeaOrder
    RegularBlackMangoHalfIceOrder --|> BubbleTeaOrder
    BigGreenStrawberryFullIceOrder --> BubbleTea
    BubbleTeaOrder --> BubbleTea
    BubbleTeaPurchase --> BubbleTeaOrder
    RegularBlackMangoHalfIceOrder --> BubbleTea

```
