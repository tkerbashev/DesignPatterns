# Interpreter

## Description

The Interpreter pattern, a behavioural design pattern, 
provides a way to define a grammatical representation 
for a language and an interpreter to interpret 
sentences in that language. 

## Scenario

We start with a simple three-word phrase in English
and wish to query a database, retrieving data relevent
to the entered phrase.
We process each of the words and form an SQL query,
which, when executed, will produce the desired result..

## Implementation

```mermaid
classDiagram
    class FirstTermExpression {
        +Interpret()
    }

    class ISQLExpression {
        <<Interface>>
        +Interpret()
    }

    class OperatorExpression {
        +Interpret()
    }

    class SecondTermExpression {
        +Interpret()
    }

    class SQLContext {
        +set_Input()
        +Input: String
        +ParsedInput: String[]
        +Output: String
        +OutputParts: String[]
        -_input: String
    }


    FirstTermExpression --|> ISQLExpression
    OperatorExpression --|> ISQLExpression
    SecondTermExpression --|> ISQLExpression
    FirstTermExpression --> SQLContext
    ISQLExpression --> SQLContext
    OperatorExpression --> SQLContext
    SecondTermExpression --> SQLContext

```
