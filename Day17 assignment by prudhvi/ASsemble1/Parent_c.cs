using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASsemble1
{
    public class Parent_c
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        /// <summary>
        /// Base Class Method
        /// </summary>
        public void BaseClassMethod()
        {
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;
        }
    }
    /// <summary>
    /// Derived Class
    /// </summary>
    public class Child_c : Parent_c
    {
        /// <summary>
        /// Derived Class Method
        /// </summary>
        public void DerivedClassMethod()
        {
            a = 10;
            //b = 20; Private variable cannot accessble in same derived class
            c = 30;
            d = 40;
            e = 50;
        }
    }
    /// <summary>
    /// Main Class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Base Class Object Created
        /// </summary>
        Child_c bc = new Child_c();
        /// <summary>
        /// Main Class Method
        /// </summary>
        public void MainClassMethod()
        {
            bc.a = 10;
            //bc.b = 20; Private variable cannot accessble in same main class
            //bc.c = 30; Protected variable cannot accessble in same main class
            bc.d = 40;
            bc.e = 50;
        }
    }
}
