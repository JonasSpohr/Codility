using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogJmp
    {
        public int run(int X, int Y, int D)
        {
            return Convert.ToInt32(Math.Ceiling((Y - (double)X) / D));
        }
    }
}
