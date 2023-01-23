using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment11
{
    public class Calculation
    {


        /* Method Overloading

        When a class contains one method name with different parameter list is called method overloading
        Method overloading will be used for ease of development, as multiple method names need not to remember.
        In method overloading no of parameters should be different.
        If no of parameters are same then data type should be different
        If data type are same then sequence should be different.
        In method overloading method call will be decided as per the parameter list
        Return type is not considered in method overloading */



        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Addition(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public double Addition(int a, double b)
        {
            return a + b;
        }
        public double Addition(double a, int b)
        {
            return a + b;
        }
        public double Addition(float a, double b)
        {
            return a + b;
        }


    }
}
