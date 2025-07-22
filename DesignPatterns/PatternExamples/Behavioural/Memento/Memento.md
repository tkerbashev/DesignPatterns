# Memento

## Description

Memento is a behavioural design pattern that lets you 
save and restore the previous state of an object 
without revealing the details of its implementation.

## Scenario

In a game of chess, both the white and the black make 
moves. With the help of the MoveMemento class we are
able to easily undo or redo a move.

## Implementation

```mermaid
classDiagram
    class ChessGame {
        +MakeMove()
        +UndoMove()
        +RedoMove()
        +ListAllMoves()
        -moves: List~Move~
        -_progress: GameProgress
    }

    class Colour {
        <<Enum>>
    }

    class GameProgress {
        +SetMemento()
        +UndoMemento()
        +RedoMemento()
        -undoMmementos: Stack~MoveMemento~
        -redoMementos: Stack~MoveMemento~
    }

    class Move {
        +ToString()
        +Colour: Colour
        +Description: String
    }

    class MoveMemento {
        +Memento: List~Move~
    }


    ChessGame --> Move
    ChessGame --> GameProgress
    ChessGame --> Colour
    GameProgress --> MoveMemento
    Move --> Colour
    MoveMemento --> Move

```
