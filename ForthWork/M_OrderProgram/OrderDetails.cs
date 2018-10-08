using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram 
{
    class OrderDetails : Object
    {
        public OrderDetails(Commodity commodity,int commodityNum)
        {
            this.commodity = commodity;
            this.commodityNum = commodityNum;
        }

        public void ChangeCommodityNum(int num)
        {
            this.CommodityNum = num;         

        }

        private Commodity commodity;

        private int commodityNum;     

        public int CommodityNum
        {
            set
            {
                if(value>=1)
                {
                    commodityNum = value;
                }
                else
                {
                    Console.WriteLine("The number of the commodity can't less than 1! ");
                }
            }
            get
            {
                return commodityNum;
            }
        }

        public override string ToString()
        {
            return commodity.CommodityName + " *" + commodityNum;
        }

    }
}
