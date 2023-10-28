namespace MarsRover;

// Usage: MarsRover/bin/Debug/net7.0/MarsRover 0:0:N MMMMLMMMRLLMMMLMMM
// Output: 0:1:E

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(
        new MarsRover(args[0]).Execute(args[1])
        );
    }
}