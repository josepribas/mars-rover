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
        string? direction = states[2];

        if (commands == "M")
        {
            _direction = CreateDirectionFrom(direction);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{direction}";
    }

    private static IDirection CreateDirectionFrom(string direction)
    {
        switch (direction)
        {
            case "N":
                return new North();
            case "W":
                return new West();
            case "E":
                return new East();
            default:
                throw new NotSupportedException();
        }
    }
}

public interface IDirection {
   Position MoveForward(Position position);
}

public class North: IDirection {
    public Position MoveForward(Position position)
    {
        position.Y++;
        return position;
    }
}

public class West: IDirection {
    public Position MoveForward(Position position)
    {
        position.X--;
        return position;
    }
}

public class East: IDirection {
    public Position MoveForward(Position position)
    {
        position.X++;
        return position;
    }
}

public class Position {
    private int _y;
    public int Y { 
        get { return _y; } 
        set { _y = value; }
        }
    private int _x;
    public int X { 
        get { return _x; } 
        set { _x = value; }
        }
}