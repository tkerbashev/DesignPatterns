# Chain of Responsibility

## Description

Chain of Responsibility is a behavioural design pattern 
that lets you pass requests along a chain of handlers. 
Upon receiving a request, each handler decides either 
to process the request or to pass it to the next 
handler in the chain.

## Scenario

We take a number and perform a series of simple 
mathematical operations. Each subsequent operation
takes the result of the previous and produces 
a number as a result. The order in which the 
operations are performed is determined by the caller.

## Implementation

```mermaid
classDiagram
    class Add {
        +Transform()
        +Update()
        +Next: Handler
        -More: Int32
    }

    class Divide {
        +Transform()
        +Update()
        +Next: Handler
        -By: Int32
    }

    class Handler {
        +Transform()
        +Update()
        +Next: Handler
    }

    class Multiply {
        +Transform()
        +Update()
        +Next: Handler
        -By: Int32
    }

    class Subtract {
        +Transform()
        +Update()
        +Next: Handler
        -Less: Int32
    }


    Add --|> Handler
    Divide --|> Handler
    Multiply --|> Handler
    Subtract --|> Handler
    Add --> Handler
    Divide --> Handler
    Multiply --> Handler
    Subtract --> Handler

```
