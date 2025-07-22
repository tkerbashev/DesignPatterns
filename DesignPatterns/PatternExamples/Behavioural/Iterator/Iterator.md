# Iterator

## Description

The Iterator design pattern is a behavioural design 
pattern that provides a way to access the elements 
of an aggregate object (like a list) sequentially.

## Scenario

Given a two-dimensional matrix with product data we
print on the screen a simple, one-dimensional list
of all the products.

## Implementation

```mermaid
classDiagram
    class IProductCollection {
        <<Interface>>
        +GetIterator()
    }

    class IProductIterator {
        <<Interface>>
        +First()
        +Next()
        +IsFinished: Boolean
        +CurrentProduct: Product
    }

    class Product {
        +ToString()
        +SerialNumber: String
        +Colour: String
    }

    class ProductCollection {
        +GetIterator()
        +GetItem()
        +Height: Int32
        +Width: Int32
    }

    class ProductIterator {
        +First()
        +Next()
        +IsFinished: Boolean
        +CurrentProduct: Product
        -_currentRow: Int32
        -_currentColumn: Int32
        -_totalRows: Int32
        -_totalColumns: Int32
    }


    ProductCollection --|> IProductCollection
    ProductIterator --|> IProductIterator
    IProductCollection --> IProductIterator
    IProductIterator --> Product
    ProductCollection --> Product
    ProductCollection --> IProductIterator
    ProductIterator --> ProductCollection
    ProductIterator --> Product

```
