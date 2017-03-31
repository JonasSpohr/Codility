using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTalChallenge_JS
{
    public class CyclicRotation
    {
        public int[] run(int[] A, int K)
        {
            if (A.Length == 0)
                return new int[] { };

            if (A.Length <= 1)
                return A;

            while (K > A.Length)
                K -= A.Length;

            int[] arrReturn = new int[A.Length];

            Array.Copy(A, A.Length - K, arrReturn, 0, K);
            Array.Copy(A, 0, arrReturn, K, arrReturn.Length - K);

            return arrReturn;
        }

    }
}
