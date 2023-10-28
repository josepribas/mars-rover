namespace MarsRover;

public class MoveForwardCommand: ICommand
{
    public Rover Apply(Position position, IDirection direction) => 
        new Rover(direction.MoveForward(position), direction);
}
