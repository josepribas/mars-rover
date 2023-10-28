using MarsRover.Directions;

namespace MarsRover;

public static class RoverFactory {
    public static Rover CreateFrom(string initialState)
    {
        string[]? states = initialState.Split(separator: ":");
        var x = int.Parse(s: states[0]);
        var y = int.Parse(s: states[1]);
        var position = new Position(x, y);
        string? directionStringCommand = states[2];
        var direction = DirectionFactory.CreateFrom(directionStringCommand);
        return new Rover(position, direction);
    }
}