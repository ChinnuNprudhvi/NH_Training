using System;
using System.IO;
using System.Collections.Generic;
using Data_access_layer;

namespace Bussiness_Logic_Library
{
    public class BusinessLogic
    {
        public static bool AddEmp()
        {
            //Check is it repeated or it is negative



            var st = Class1.FilePath;

        iSitnegativeOrRepeated:
            int ID_Number;
            Console.WriteLine("Enter the ID Number:");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            StreamReader sr = new StreamReader(st);

            string line = sr.ReadLine();
            bool verify = false;
            while (line != null)
            {
                var lineSplit = line.Split(',');
                if (lineSplit[0] == EmpId.ToString())
                {
                    verify = true;
                    break;
                }
                else
                {
                    line = sr.ReadLine();
                }
            }
            sr.Close();

            if (EmpId <= 0 || verify)
            {
                Console.WriteLine("Check the Entered Number Wheather its above zero and Id Number Not Repeated");
                goto iSitnegativeOrRepeated;
            }
            else
            {
                ID_Number = EmpId;
            }
        //Check the Length of The name

        NameLenCheck:
            string Emp_Name;
            Console.WriteLine("Enter name:");
            string empName = Console.ReadLine();
            if (empName.Length < 3)
            {
                Console.WriteLine("Enter name Atleast of 3 characters");
                goto NameLenCheck;
            }
            else
            {
                Emp_Name = empName;
            }
        //Salary Check
        EmpSalaryCheck:
            int Emp_Salary;
            Console.WriteLine("Enter Salary");
            int empSalary = Convert.ToInt32(Console.ReadLine());

            if (empSalary < 12000)
            {
                Console.WriteLine("salary should be greater than 12000");
                goto EmpSalaryCheck;
            }
            else
            {
                Emp_Salary = empSalary;
            }
        //age Check
        EmpageCheck:
            int Emp_Age;
            Console.WriteLine("Enter Age");
            int empAge = Convert.ToInt32(Console.ReadLine());
            if (empAge <= 18 || empAge >= 58)
            {
                Console.WriteLine("Check your age it should be more than 18 and less than 58");
                goto EmpageCheck;
            }
            else
            {
                Emp_Age = empAge;
            }
            var result = Class1.Add_Employee(ID_Number, Emp_Name, Emp_Salary, Emp_Age);
            return result;
        }

        public static List<string> Search_EmpDetailsById(int empId)
        {
            var empDetailsId = Class1.Search_emp_Detail(empId);
            return empDetailsId;
        }
        public static List<string> Search_EmpDetailsByName(string empName)
        {
            var empDetailsName = Class1.EmpDetailsByName(empName);
            return empDetailsName;
        }
        public static List<string> DisplayEmployeeDetails()
        {
            var empDetails = Class1.AllEmpDetails();
            return empDetails;
        }




    }
}
