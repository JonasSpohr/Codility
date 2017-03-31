using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTalChallenge_JS
{
    public class PassingCars
    {
        public int run(int[] A)
        {
            int carsEast = 0;
            int carsPassing = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    carsEast++;
                }
                else
                {
                    carsPassing += carsEast;
                }
            }

            if (carsPassing < 0)
                return -1;

            return carsPassing > 1000000000 ? -1 : carsPassing;
        }
    }
}
