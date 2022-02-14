using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pHYSICs
{
    public class Phsics
    {
        public void Power(int v , int i)
        {
            Console.WriteLine( $"power = {v*i}watts");
        }
        public void voltage(int i, int r)
        {
            Console.WriteLine($"power = {r * i}watts");
        }
        public void current(int v, int r)
        {
            Console.WriteLine($"current = {v/r}");
        }
    }
}
