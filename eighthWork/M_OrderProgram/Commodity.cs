using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    public class Commodity : Object
    {
        public double price;
        public uint Id { set; get; }

        public Commodity() { }
        public Commodity(string name,double price,uint id)
        {
            Name = name;
            Price = price;
            Id = id;
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
            return Name + $"  price:{price}";
        }

    }
}
