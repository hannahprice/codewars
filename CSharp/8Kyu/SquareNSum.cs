using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] n)
  { 
      return n.Any() ? n.Select(x => x * x).Sum() : default;
  }
}