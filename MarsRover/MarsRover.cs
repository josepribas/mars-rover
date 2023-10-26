namespace MarsRover.Tests;

public class MarsRover {

    private readonly string _initialState;
    private Position _position;
    private IDirection _direction;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
        _position = new Position();
    }

    public object Execute(string commands)
    {
        string[]? states = _initialState.Split(separator: ":");
        _position.X = int.Parse(s: states[0]);
        _position.Y = int.Parse(s: states[1]);
        string? directionStringCommand = states[2];

        if (commands == "M")
        {
            _direction = DirectionFactory.CreateDirectionFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }

    
}
