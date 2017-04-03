using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class PermCheck
    {
        public int run(int[] A)
        {
            HashSet<int> _maps = new HashSet<int>();

            A = A.OrderBy(c => c).ToArray();

            if (A.Length >= 1 && A[0] != 1)
                return 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (_maps.Contains(A[i]))
                    return 0;

                if (i > 0 && A[i - 1] + 1 != A[i])
                    return 0;

                _maps.Add(A[i]);
            }

            return 1;
        }
    }
}
