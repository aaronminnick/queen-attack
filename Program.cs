using System;

public static void Main()
{
  int queenX;
  int queenY;
  int targetX;
  int targetY;

  Console.WriteLine("Where is the queen? (x,y)");
  string[] queenCoordArray = Console.ReadLine().Split(',');
  queenX = queenCoordArray[0];
  queenY = queenCoordArray[1];
  Queen queen = new Queen(queenX, queenY);

  Console.WriteLine("Where is the target? (x,y)");
  string[] targetCoordArray = Console.ReadLine().Split(',');
  targetX = targetCoordArray[0];
  targetY = targetCoordArray[1];

  if (queen.CanAttack(targetX, targetY))
  {
    Console.WriteLine("Yes, the queen can attack that.")
  }
  else
  {
    Console.WriteLine("No, the queen cannot attack that.")
  }
}