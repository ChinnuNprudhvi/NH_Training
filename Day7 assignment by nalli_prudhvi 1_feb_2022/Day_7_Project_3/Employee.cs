using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_3
{
    internal class Employee
    {
        public int Employee_ID;
        public string Employee_name;
        public int Employee_age;
        public int Employee_salary;

        public void Employee_Data()
        {
            Console.WriteLine($"your name      :{Employee_ID}");
            
            Console.WriteLine($"Employee_ID    :{Employee_name}");
            
            Console.WriteLine($"Employee_age   :{Employee_age}");
            
            Console.WriteLine($"Employee_age   :{Employee_salary}");
            
        }

    }
}
