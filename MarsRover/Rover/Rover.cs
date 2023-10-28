using Microsoft.VisualBasic;

namespace MarsRover;

public class Rover {
    private readonly Position _position;
    private readonly IDirection _direction;

    public Rover(
        Position position,
        IDirection direction
    ) {
        _position = position;
        _direction = direction;
    }

    public Rover Apply(ICommand command) 
    {
        return command.Apply(_position, _direction);
    }

    public string PrintState() => $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";


}
