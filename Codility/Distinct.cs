using System.Collections.Generic;

namespace Codility
{
    public class Distinct
    {
        public int run(int[] A)
        {
            HashSet<int> items = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!items.Contains(A[i]))
                    items.Add(A[i]);
            }

            return items.Count;
        }

    }
}
