using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTalChallenge_JS
{
    public class GenomicRangeQuery
    {
        public int[] run(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                var dna = S.Substring(P[i], Q[i] - P[i] == 0 ? 1 : Q[i] - P[i] + 1);

                if (dna.IndexOf("A", StringComparison.Ordinal) != -1)
                    result[i] = 1;
                else if (dna.IndexOf("C", StringComparison.Ordinal) != -1)
                    result[i] = 2;
                else if (dna.IndexOf("G", StringComparison.Ordinal) != -1)
                    result[i] = 3;
                else
                    result[i] = 4;
            }

            return result;
        }
    }
}
