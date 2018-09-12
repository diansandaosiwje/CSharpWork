using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double x = 0, y = 0;

            Console.Write("Please input a number x:");
            s = Console.ReadLine();
            x = Double.Parse(s);


            Console.Write("Please input a number y:");
            s = Console.ReadLine();
            y = Double.Parse(s);


            s = "" + x * y;
            Console.WriteLine("The product of x and y is: " + s);
        }
    }
}
