namespace MarsRover;

public class TurnRightCommand: ICommand
{
    public Rover Apply(Position position, IDirection direction) => 
        new Rover(position, direction.ToRight());
}
