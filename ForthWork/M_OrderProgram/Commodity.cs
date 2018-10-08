using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class Commodity : Object
    {
        public Commodity(string commodityName,double commodityPrice)
        {
            CommodityName = commodityName;
            CommodityPrice = commodityPrice;
        }

        public string CommodityName;
        public double CommodityPrice;

        public override string ToString()
        {
            return CommodityName +" "+ CommodityPrice+"yuan";
        }

    }
}
