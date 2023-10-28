namespace MarsRover;

public interface ICommand {
    Rover Apply(Position position, IDirection direction);
}
