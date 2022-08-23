using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    public class CombinationCalculator
    {
        public int Calculate(int n, int k)
        {
            if (n == k || k == 0)
                return 1;
            if (n <= 0 && k >= 1)
                return 0;

            return Calculate(n - 1, k - 1) + Calculate(n - 1, k);
        }
    }
}
