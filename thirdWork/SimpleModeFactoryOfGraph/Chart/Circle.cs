using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph
{
    public  class Circle : BaseChart
    {
        private double radius=0;

        public override void Init()
        {
            base.Init();

            Console.WriteLine("Please input the radius of the circle: ");
            this.radius = Double.Parse(Console.ReadLine());
        }

        public override double Area
        {
            get
            {
                return radius * radius * System.Math.PI;
            }
        }

    }
}
