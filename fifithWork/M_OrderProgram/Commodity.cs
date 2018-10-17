using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class Commodity : Object
    {
        private double price;

        public Commodity(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >=0！"); //异常实例 学到了
                price = value;
            }
        }

        public string Name { get; set; }
       

        public override string ToString()
        {
            return Name +" "+ Price+"yuan" +
                "";
        }

    }
}
