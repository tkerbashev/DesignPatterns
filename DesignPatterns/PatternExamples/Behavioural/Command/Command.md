# Command

## Description

The Command Pattern is a behavioural design pattern 
that turns a request into a stand-alone object 
containing all the information needed to execute 
the request.

## Scenario

The user moves the cursor around the screen using the
arrow keys. Each move is encapsulated into a 
MoveCommand object and stored into a collection inside 
the PositionTracker.
When finished the list of the executed commands 
is retrieved and presented on the screen in
order of their execution.


## Implementation

```mermaid
classDiagram
    class CommandParameters {
        +VerticalPosition: Int32
        +HorizontalPosition: Int32
        +Direction: String
        +MaxHeight: Int32
        +MaxWidth: Int32
    }

    class ILogger {
        <<Interface>>
        +Log()
    }

    class ISurface {
        <<Interface>>
        +Display()
        +SetPosition()
        +Width: Int32
        +Height: Int32
    }

    class Logger {
        +Log()
    }

    class MoveCommand {
        +Execute()
        -keyInfo: ConsoleKeyInfo
    }

    class PositionTracker {
        +AddCommand()
        +ListExecutedCommands()
        +DisplayMovement()
        -logger: ILogger
        -surface: ISurface
        -moveCommands: List~MoveCommand~
    }

    class Surface {
        +Display()
        +SetPosition()
        +Width: Int32
        +Height: Int32
    }


    Logger --|> ILogger
    Surface --|> ISurface
    MoveCommand --> CommandParameters
    PositionTracker --> ILogger
    PositionTracker --> ISurface
    PositionTracker --> MoveCommand
    PositionTracker --> CommandParameters

```
