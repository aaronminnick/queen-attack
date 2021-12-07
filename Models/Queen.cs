using System;

namespace Queen_Attack.Models
{
  public class Queen
  {
    private int _x;
    private int _y;
    public Queen(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public bool CanAttack(int targetX, int targetY)
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