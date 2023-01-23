using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculation c1 = new Calculation();
            Console.WriteLine(c1.Addition(10,10));
            Console.WriteLine(c1.Addition(10,10,10));
            Console.WriteLine(c1.Addition(10,10,10,10));
            Console.WriteLine(c1.Addition(10.0,12));
            Console.WriteLine(c1.Addition(12,10.0));
            Console.WriteLine(c1.Addition(12.2,10));




        }
    }
}
