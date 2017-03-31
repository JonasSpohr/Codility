using System;
using System.Linq;

namespace TopTalChallenge_JS
{
    public class TapeEquilibrium
    {
        public int run(int[] A)
        {
            int sum1 = 0;
            int sum2 = A.Sum();
            int minDiff = int.MaxValue;

            for (int p = 0; p < A.Length - 1; p++)
            {
                sum1 += A[p];
                sum2 -= A[p];

                int diff = sum2 - sum1;
                minDiff = Math.Min(minDiff, Math.Abs(diff));
            }
            return minDiff;
        }
    }
}
