namespace MarsRover;

public class MarsRover {

    private Rover _rover;

    public MarsRover(string initialState)
    {
         _rover = RoverFactory.CreateFrom(initialState);
    }

    public string Execute(string stringCommands)
    {       
        var commands = stringCommands.ToCharArray().Select(CommandFactory.CreateFrom).ToList();
        commands.ForEach(c => _rover = _rover.Apply(c));
        return _rover.PrintState();
    }

}
