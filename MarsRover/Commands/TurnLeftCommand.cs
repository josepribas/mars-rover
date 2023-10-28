namespace MarsRover;

public class TurnLeftCommand: ICommand
{
    public Rover Apply(Position position, IDirection direction) => 
        new Rover(position, direction.ToLeft());
}
