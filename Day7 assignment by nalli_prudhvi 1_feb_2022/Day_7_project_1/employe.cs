using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_project_1
{
    internal class employe
    {
        private int employeID;
        private string employeName;
        private string employeDesignation;

        public void Employe_data()
        {
            Console.Write("Enter your Id_no :");
            employeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Name :");
            employeName = Console.ReadLine();
            Console.Write("Enter your Designation :");
            employeDesignation = Console.ReadLine();
            Console.WriteLine();

        }
        public void Employe_print_data()
        {
            Console.WriteLine($"Hello {employeName}");
            Console.WriteLine($"your id_no : {employeID}");
            Console.WriteLine($"your designation : {employeDesignation}");
            Console.WriteLine();
        }

    }
}
