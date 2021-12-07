using System;

namespace Queen.Models
{
  public class Queen
  {
    private int _x;
    private int _y;
    public void Queen(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public static bool CanAttack(int targetX, int targetY)
    {
      if (_x == targetX || _y == targetY)
      {
        return true;
      }
      else if (Math.Abs(_x - targetX) == Math.Abs(_y - targetY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}