# Abstract Factory

## Description

The Abstract Factory Pattern is a way of organising 
how you create groups of things that are related to 
each other.

## Scenario

My morning routine includes drinking either tea or 
coffee. I have both tea and coffee cups, but I don't
want to drink my tea from a coffee cup or vice versa.
Therefore, when I model my morning routine I 
instantiate either the TeaFactory or the CoffeeFactory.
The factory that I choose makes sure that the beverage
is served in the appropriate cup.

## Implementation

```mermaid
classDiagram
    class CoffeeCupService {
        +GlassType: String
    }

    class CoffeeFactory {
        +PrepareBeverageService()
        +PrepareDrinkwareService()
    }

    class CoffeeService {
        +BeverageType: String
    }

    class IBeverage {
        <<Interface>>
        +PrepareBeverageService()
        +PrepareDrinkwareService()
    }

    class IBeverageService {
        <<Interface>>
        +BeverageType: String
    }

    class IDrinkwareService {
        <<Interface>>
        +GlassType: String
    }

    class MorningRoutine {
        +Drink()
        -_beverageService: IBeverageService
        -_drinkwareService: IDrinkwareService
    }

    class TeaCupService {
        +GlassType: String
    }

    class TeaFactory {
        +PrepareBeverageService()
        +PrepareDrinkwareService()
    }

    class TeaService {
        +BeverageType: String
    }


    CoffeeFactory --|> IBeverage
    TeaFactory --|> IBeverage
    CoffeeService --|> IBeverageService
    TeaService --|> IBeverageService
    CoffeeCupService --|> IDrinkwareService
    TeaCupService --|> IDrinkwareService
    CoffeeFactory --> IBeverageService
    CoffeeFactory --> IDrinkwareService
    IBeverage --> IBeverageService
    IBeverage --> IDrinkwareService
    MorningRoutine --> IBeverageService
    MorningRoutine --> IDrinkwareService
    TeaFactory --> IBeverageService
    TeaFactory --> IDrinkwareService

```
