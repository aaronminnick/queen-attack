using System;
using Queen_Attack.Models;

public class Program
{
  public static void Main()
  {
    int queenX;
    int queenY;
    int targetX;
    int targetY;

    Console.WriteLine("Where is the queen? (x,y)");
    string[] queenCoordArray = Console.ReadLine().Split(',');
    queenX = int.Parse(queenCoordArray[0]);
    queenY = int.Parse(queenCoordArray[1]);
    Queen queen = new Queen(queenX, queenY);

    Console.WriteLine("Where is the target? (x,y)");
    string[] targetCoordArray = Console.ReadLine().Split(',');
    targetX = int.Parse(targetCoordArray[0]);
    targetY = int.Parse(targetCoordArray[1]);

    if (queen.CanAttack(targetX, targetY))
    {
      Console.WriteLine("Yes, the queen can attack that.");
    }
    else
    {
      Console.WriteLine("No, the queen cannot attack that.");
    }
  }
}