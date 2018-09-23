using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph
{
    class ChartFactory
    {
        public static BaseChart GetChart(string type)
        {
            BaseChart baseChart = null;

            if (type.Equals("circle"))
            {
                baseChart = new Circle();
            }
            else if(type.Equals("square"))
            {
                baseChart = new Square();
            }
            else if (type.Equals("rectangle"))
            {
                baseChart = new Rectangle();
            }
            else if(type.Equals("triangle"))
            {
                baseChart = new Triangle();
            }

            baseChart.Init();

            return baseChart;
        }

    }
}
