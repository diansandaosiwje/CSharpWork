using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram 
{
    public class OrderDetail : Object
    {
        public OrderDetail() { }
        public OrderDetail(Commodity commodity,uint commodityNum)
        {
            this.Commodity = commodity;
            this.Quantity = commodityNum;
        }

        public void ChangeCommodityNum(uint num)
        {
            this.Quantity = num;         

        }

        public Commodity Commodity { set; get; }

          

        public uint Quantity { set; get; }

        public override string ToString()
        {
            return Commodity.Name + " *" + Quantity;
        }

    }
}
