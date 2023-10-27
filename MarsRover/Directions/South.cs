namespace MarsRover;

public class South: IDirection {
    public Position MoveForward(Position position) => new Position(position.X, position.Y - 1);

    public string AsStringCommand() => "S";
    public IDirection ToRight() => new West();
    public IDirection ToLeft() => new East();
}
