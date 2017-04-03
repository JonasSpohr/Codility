using System.Collections.Generic;

namespace Codility
{
    public class Dominator
    {
        public int run(int[] A)
        {
            if (A.Length == 0)
                return -1;

            Stack<int> s = new Stack<int>();
            var index = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (s.Count == 0 || s.Peek() == A[i])
                {
                    s.Push(A[i]);
                }
                else
                    s.Pop();
            }

            var total = 0;
            var dominator = -1;

            if (s.Count > 0)
            {
                dominator = s.Peek();
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == dominator)
                    {
                        total++;
                        if (index == -1)
                            index = i;
                    }
                }
            }

            if (total > A.Length / 2)
                return index;

            return -1;
        }
    }
}
