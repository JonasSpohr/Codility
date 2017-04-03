using System;

namespace Codility
{
    public class MaxProfit
    {
        public int run(int[] A)
        {
            int minProfit = 200000;
            int maxProfix = 0;
            if (A.Length == 0)
                return 0;

            foreach (int v in A)
            {
                minProfit = Math.Min(v, minProfit);
                maxProfix = Math.Max(v - minProfit, maxProfix);
            }

            return maxProfix;
        }
    }
}
