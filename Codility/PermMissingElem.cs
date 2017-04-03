using System.Linq;

namespace Codility
{
    public class PermMissingElem
    {
        public int run(int[] A)
        {
            if (A.Length == 0)
                return 1;

            if (A.Length == 1 && A[0] > 1)
                return A[0] - 1;

            A = A.OrderBy(c => c).ToArray();

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (i == 0 && A[i] > 1)
                    return A[i] - 1;

                if (i > 0 && A[i - 1] != A[i] - 1)
                    return A[i] - 1;

                if (A[i] + 1 != A[i + 1])
                    return A[i] + 1;
            }

            return A.Length + 1;
        }

    }
}
