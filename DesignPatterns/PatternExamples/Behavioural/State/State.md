# State

## Description

State is a behavioral design pattern that lets an 
object alters its behaviour when its internal state 
changes. It appears as if the object changed its class.

## Scenario

We have a car that is being driven. Depending on
whether you go uphill or downhill, you need to either
add gas or tap the brakes. The slope of the road in
our case corresponds to the internal state.

## Implementation

```mermaid
classDiagram
    class Car {
        +ChangeRoadType()
        +Drive()
        -_drivingType: DrivingType
        -_drivingUphill: Lazy`1
        -_drivingDownhill: Lazy`1
        -_drivingOnFlatRoad: Lazy`1
    }

    class DrivingDownhill {
        +Drive()
        +Car: Car
        +RoadType: RoadType
    }

    class DrivingOnFlatRoad {
        +Drive()
        +Car: Car
        +RoadType: RoadType
    }

    class DrivingType {
        +Drive()
        +Car: Car
        +RoadType: RoadType
    }

    class DrivingUphill {
        +Drive()
        +Car: Car
        +RoadType: RoadType
    }

    class RoadType {
        <<Enum>>
    }


    DrivingDownhill --|> DrivingType
    DrivingOnFlatRoad --|> DrivingType
    DrivingUphill --|> DrivingType
    Car --> DrivingType
    Car --> DrivingUphill
    Car --> DrivingDownhill
    Car --> DrivingOnFlatRoad
    Car --> RoadType
    DrivingDownhill --> Car
    DrivingDownhill --> RoadType
    DrivingOnFlatRoad --> Car
    DrivingOnFlatRoad --> RoadType
    DrivingType --> Car
    DrivingType --> RoadType
    DrivingUphill --> Car
    DrivingUphill --> RoadType

```
