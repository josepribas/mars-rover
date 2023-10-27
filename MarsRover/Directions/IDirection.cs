namespace MarsRover;

public interface IDirection {
   Position MoveForward(Position position);
   string AsStringCommand();

   IDirection ToRight();
   IDirection ToLeft();
}
