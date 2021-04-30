using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_2
{
    partial class Refrigerator
    {
        public bool IsOptimalPrice(int optimalPrice)
        {
            if (Price <= optimalPrice)
                return true;

            return false;
        }
    }
}
