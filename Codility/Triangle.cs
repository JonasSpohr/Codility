using System.Linq;

namespace Codility
{
    public class Triangle
    {
        public int run(int[] A)
        {
            A = A.OrderBy(c => c).ToArray();

            if (A.Length >= 3)
            {
                for (int i = 0; i < A.Length - 2; i++)
                {
                    if (A[i] + A[i + 1] > A[i + 2])
                        return 1;
                }
            }

            return 0;
        }
    }
}
