namespace DesignPatterns.PatternExamples.Behavioural.State;

public class Car
{
    private DrivingType _drivingType;
    private readonly Lazy<DrivingUphill> _drivingUphill;
    private readonly Lazy<DrivingDownhill> _drivingDownhill;
    private readonly Lazy<DrivingOnFlatRoad> _drivingOnFlatRoad;

    public Car()
    {
        _drivingUphill = new Lazy<DrivingUphill>( ( ) => new DrivingUphill( this ) );
        _drivingDownhill = new Lazy<DrivingDownhill>( ( ) => new DrivingDownhill( this ) );
        _drivingOnFlatRoad = new Lazy<DrivingOnFlatRoad>( ( ) => new DrivingOnFlatRoad( this ) );
        
        //Set a flat road as default
        _drivingType = new DrivingUphill( this );
    }

    public void ChangeRoadType( RoadType type ) 
    {
        switch ( type ) 
        {
            case RoadType.Uphill:
                _drivingType = _drivingUphill.Value; 
                break;
            case RoadType.Downhill:
                _drivingType = _drivingDownhill.Value;
                break;
            case RoadType.Flat:
                _drivingType = _drivingOnFlatRoad.Value;
                break;
        }
    }

    public void Drive()
    {
        _drivingType.Drive();
    }
}
