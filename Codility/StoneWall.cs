using System.Collections.Generic;

namespace Codility
{
    public class StoneWall
    {
        public int run(int[] H)
        {
            int c = 0;
            Stack<int> s = new Stack<int>();

            foreach (int h in H)
            {
                while (s.Count > 0 && s.Peek() > h)
                    s.Pop();


                if (s.Count == 0 || s.Peek() < h)
                {
                    s.Push(h);
                    c += 1;
                }
            }

            return c;
        }
    }
}
