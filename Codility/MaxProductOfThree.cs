using System;
using System.Linq;

namespace Codility
{
    public class MaxProductOfThree
    {
        public int run(int[] A)
        {
            A = A.OrderBy(c => c).ToArray();

            int l = A.Length - 1;

            int p = A[l] * A[l - 1] * A[l - 2];
            int n = A[0] * A[1] * A[l];

            return Math.Max(p, n);
        }

    }
}
