using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTalChallenge_JS
{
    public class CountDiv
    {
        public int run(int A, int B, int K)
        {
            if (B - A >= K)
            {
                return A % K == 0 ? (B / K - A / K) + 1 : (B / K - A / K);
            }

            return A % K == 0 ? 1 : 0;
        }

    }
}
