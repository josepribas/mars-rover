namespace MarsRover;

public static class CommandFactory {
    public static ICommand CreateFrom(char command) {
        return command switch {
            'M' => new MoveForwardCommand(),
            'L' => new TurnLeftCommand(),
            'R' => new TurnRightCommand(),
            _ => throw new NotSupportedException($"Command {command} not supported")
        };
    }
}