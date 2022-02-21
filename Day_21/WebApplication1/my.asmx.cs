using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for my
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class my : System.Web.Services.WebService
    {

        [WebMethod]
        public int factorial(int n)
        {  
            int fact = 1, i;
            for(i = 1; i < n+1; i++)
            {
                fact *= i;
            }
            return fact;
        }
        [WebMethod]
        public int add(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public int sub(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public int mul(int a,int b)
        {
            return a * b;
        }
        [WebMethod]
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
