using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph
{
    class User
    {
        static private string type;
        static void Main()
        {
            int choose;
            do
            {
                Console.WriteLine("Please choose the number of the chart which will be draw: 1 circle, 2 square, 3 triangle, 4 rectangle: ");

                string input = Console.ReadLine();
              
                if (int.TryParse(input, out choose))
                {
                    if (choose < 5 && choose > 0)
                    { break; }
                   
                }
                else
                {
                    continue;
                }     
                
            } while (true);

            switch(choose)
            {
                case 1:
                    type = "circle";
                    break;
                case 2:
                    type = "square";
                    break;
                case 3:
                    type = "triangle";
                    break;
                case 4:
                    type = "rectangle";
                    break;
            }

            BaseChart chart;
            chart = ChartFactory.GetChart(type);

            Console.WriteLine( "The area of the "+type+" is "+chart.Area+" .");

        }
    }
}
