namespace MarsRover;

public class South: IDirection {
    public Position MoveForward(Position position) => new Position(position.X, position.Y - 1);
}