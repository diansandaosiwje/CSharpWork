﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph
{
    class Rectangle : BaseChart
    {
        private double width=0;
        private double height=0;

        public override void Init()
        {
            base.Init();

            Console.WriteLine("Please input the width and height of the rectangle: ");

            Console.WriteLine("width: ");      
            this.width = Double.Parse(Console.ReadLine());

            Console.WriteLine("height: ");
            this.height = Double.Parse(Console.ReadLine());
        }


        public override double Area
        {
            get
            {
                return this.width * this.height;
            }
        }

    }
}
