using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTesting
{
    internal class PowerOf
    {
        int baseNum;
        int power;
       public PowerOf(int baseNum, int power)
        {
            this.baseNum = baseNum;
            this.power = power;
            
            }

        public int Power()
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total *= baseNum;
            }
            return total;
        }


    }
}
