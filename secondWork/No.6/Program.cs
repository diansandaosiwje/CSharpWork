using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input an int greater than 1 to seek all its prime factor : ");
            int num = 0;

            try
            {
                num = Int32.Parse(Console.ReadLine());

                if(num<=1)
                {
                    Console.WriteLine("Please input an int greater than 1 ");
                }

                while(num!=1)
                {
                    MinPrimeNum(ref num);
                }
            }

            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
            }
        }

        static void MinPrimeNum(ref int  num)
        {
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    num = num / i;
                    return;
                }
            }
        }

    }
}
