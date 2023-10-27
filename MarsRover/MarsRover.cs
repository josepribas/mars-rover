using MarsRover.Directions;

namespace MarsRover;

public class MarsRover {

    private readonly string _initialState;
    private Position _position;
    private IDirection _direction;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public object Execute(string commands)
    {
        string[]? states = _initialState.Split(separator: ":");
        var x = int.Parse(s: states[0]);
        var y = int.Parse(s: states[1]);
        _position = new Position(x, y);
        string? directionStringCommand = states[2];

        if (commands == "M")
        {
            _direction = DirectionFactory.CreateFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }

    
}
