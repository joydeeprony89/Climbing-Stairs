using System;

namespace Climbing_Stairs
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      int result = s.ClimbStairs(7);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    public int ClimbStairs(int n)
    {
      if (n == 1) return 1;
      if (n == 2) return 2;
      int[] dp = new int[n + 1];
      dp[0] = 0;
      dp[1] = 1;
      dp[2] = 2;
      for (int i = 3; i <= n; i++)
      {
        dp[i] = dp[i - 2] + dp[i - 1];
      }

      return dp[n];
    }
  }
}
