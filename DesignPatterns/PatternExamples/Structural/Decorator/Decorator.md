# Decorator

## Description

Decorator is a structural design pattern that lets you 
attach new behaviours to objects by placing these objects 
inside special wrapper objects that contain the behaviours.

## Scenario

A person goes home after work either by car or by bus.
Some days the person needs to buy groceries; at others - 
meet with friends. We wrap the specific ComeHome objects,
adding the additional behaviour of buying groceries or
having a drink with friends.

## Implementation

```mermaid
classDiagram
    class ComeHomeBuyGroceries {
        +Describe: String
    }

    class ComeHomeByBus {
        +Describe: String
    }

    class ComeHomeByCar {
        +Describe: String
    }

    class ComeHomeDecoratorBase {
        +Describe: String
        -_comeHome: IComeHome
    }

    class ComeHomeHaveDringWithFriends {
        +Describe: String
    }

    class IComeHome {
        <<Interface>>
        +Describe: String
    }


    ComeHomeBuyGroceries --|> ComeHomeDecoratorBase
    ComeHomeHaveDringWithFriends --|> ComeHomeDecoratorBase
    ComeHomeBuyGroceries --|> IComeHome
    ComeHomeByBus --|> IComeHome
    ComeHomeByCar --|> IComeHome
    ComeHomeDecoratorBase --|> IComeHome
    ComeHomeHaveDringWithFriends --|> IComeHome
    ComeHomeDecoratorBase --> IComeHome

```
