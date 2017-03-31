using System.Linq;

namespace TopTalChallenge_JS
{
    public class MissingInteger
    {
        public int run(int[] A)
        {
            A = A.OrderBy(c => c).ToArray();

            int r = 1;
            int i = 0;

            while (i < A.Length && A[i] < 1)
                i++;

            while (i < A.Length && r == A[i])
            {
                while (i < A.Length - 1 && A[i] == A[i + 1])
                    i++;

                i++;
                r++;
            }

            return r;
        }
    }
}
