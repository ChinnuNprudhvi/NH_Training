using System;
using System.Collections.Generic;
using System.IO;

namespace Data_access_layer
{
    public class Class1
    {
        public static string FilePath = "c:\\MyProject\\EmpDetails.txt";
        
        


        public static bool Add_Employee(int EmpId, string EmpName, int EmpSalary, int EmpAge)
        {
            var str = string.Concat(EmpId, ", ", EmpName, ", ", EmpSalary, ", ", EmpAge);
            File.AppendAllText(FilePath, str + Environment.NewLine);
            Console.WriteLine("Employee Entered!");
            return true;
        }

        public static List<string> Search_emp_Detail(int Id)
        {
            var EmpList = new List<string>();
            StreamReader sr = new StreamReader(FilePath);
            string Emp_Details = sr.ReadLine();
            while (Emp_Details != null)
            {
                var EmpId_split = Emp_Details.Split(',');

                if( Convert.ToInt32(EmpId_split[0]) == Id)
                {
                    EmpList.Add(Emp_Details);
                    break;
                }

                Emp_Details = sr.ReadLine();
            }
            
            sr.Close();
           
            return EmpList;
             
        }
        public static List<string> EmpDetailsByName(string name )
        {
            var EmpNames = new List<string>();
            StreamReader sr = new StreamReader(FilePath);
            string Emp_Details = sr.ReadLine();
            while (Emp_Details != null)
            {
                var EmpId_split = Emp_Details.Split(',');

                if (EmpId_split[1].Contains(name))
                {
                    EmpNames.Add(EmpId_split[1]);
                    break;
                }

                Emp_Details = sr.ReadLine();
            }
            sr.Close();
            return EmpNames;
        }
        public static List<string> AllEmpDetails()
        {
            var vs = new List<string> {};
            StreamReader sr = new StreamReader(FilePath);
            string AllEmp = sr.ReadLine();
            while(AllEmp != null)
            {
                vs.Add(AllEmp);
                AllEmp = sr.ReadLine();
            }
            sr.Close();
            return vs;
        }


    }
}
