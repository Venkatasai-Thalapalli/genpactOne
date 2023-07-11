using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethod
{
    public class Emp
    {
        public string Fullname(string fname, string lname)
        {
            return fname + " " + lname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine(emp.Fullname("Jake", "Peralta"));
            Console.WriteLine(emp.Fullname(lname: "Peratla", fname: "Jake"));
            Console.ReadKey();
        }
    }
}
