using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicLibrarry
{
    public class FactorialofNUm
    {
        public int Fact(int z)
        {
            if (z <= 1)
            {

                return 1;
            }
            else
            {
                return z*Fact(z-1);
            }
        }
    }
}
