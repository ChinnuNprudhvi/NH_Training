using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASsemble1;

namespace Another_Lib
{
    public class AnotherAssCl : Parent_c
    {
        public void AnotherClMet()
        {
            a = 10;
            //b = 20; Private variable cannot accessble in other derived class
            c = 30;
            //d = 40; Internal variable cannot accessble in other derived class
            e = 50;
        }

    }
    public class OtherMain
    {
        Parent_c bc = new Parent_c();   
        public void OtherMainClassMethod()
        {
            bc.a = 10;
            //bc.b = 20; Private variable cannot accessble in other main class
            //bc.c = 30; Protected variable cannot accessble in other main class
            //bc.d = 40; Internal variable cannot accessble in other main class
            //bc.e = 50; Protected Internal variable cannot accessble in other main class
        }

    }

}
