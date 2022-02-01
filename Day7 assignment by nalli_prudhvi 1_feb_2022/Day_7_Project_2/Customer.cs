using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_2
{
    internal class Customer
    {
        private int CustomerID;
        private string CustomerName;
        private string CustomerEmail;

        public void Customer_data()
        {
            Console.Write("Enter your CustomerID :");
            CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your CustomerName :");
            CustomerName = Console.ReadLine();
            Console.Write("Enter your CustomerEmailID :");
            CustomerEmail = Console.ReadLine();
            Console.WriteLine();

        }
        public void Customer_print_data()
        {
            Console.WriteLine($"your name     : {CustomerName}");
            Console.WriteLine($"your id_no    : {CustomerID}");
            Console.WriteLine($"your EmailId  : {CustomerEmail}");
            Console.WriteLine();

        }
    }
}
