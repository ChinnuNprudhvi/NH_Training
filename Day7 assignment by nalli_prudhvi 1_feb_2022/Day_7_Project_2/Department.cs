using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_2
{
    internal class Department
    {
        private int DeptID;
        private string DeptNumber;
        private string DeptType;

        public void Department_data()
        {
            Console.Write("Enter your Id_no :");
            DeptID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Name :");
            DeptNumber = Console.ReadLine();
            Console.Write("Enter your Designation :");
            DeptType = Console.ReadLine();
            Console.WriteLine();

        }
        public void Department_print_data()
        {
            Console.WriteLine($"This is dept. ID     : {DeptID}");
            Console.WriteLine($"This is dept. Number : {DeptNumber}");
            Console.WriteLine($"This is dept. Type   : {DeptType}");
            Console.WriteLine();

        }
    }
}
