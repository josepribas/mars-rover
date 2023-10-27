namespace MarsRover;

public class Position {
    private int _y;
    public int Y { get => _y; } 
        

    private int _x;
    public int X { get => _x; } 

    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }
}