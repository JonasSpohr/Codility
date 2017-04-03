using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class OddOccurrencesInArray
    {
        public int run(int[] A)
        {
            HashSet<int> unPaird = new HashSet<int>();

            foreach (var i in A)
            {
                if (!unPaird.Contains(i))
                {
                    unPaird.Add(i);
                }
                else
                {
                    unPaird.Remove(i);
                }
            }

            return unPaird.FirstOrDefault();
        }
    }
}
