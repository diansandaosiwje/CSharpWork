using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph 
{
    class Square : BaseChart
    {
        private double side=0;

        public override void Init()
        {
            base.Init();

            Console.WriteLine("Please input the side of the square: ");
            this.side = Double.Parse(Console.ReadLine());

        }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }


    }
}
