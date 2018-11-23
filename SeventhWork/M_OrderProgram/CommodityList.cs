using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    public static class CommodityList
    {
        static public List<Commodity> commodities = new List<Commodity>();
        

        static public void AddCommodity (Commodity commodity)
        {
            commodities.Add(commodity);
        }

        static public void RemoveCommodity(Commodity commodity)
        {
            try
            {
                commodities.Remove(commodity);
            }
            catch
            {
                Console.WriteLine("There is no such commodity here !");
            }
          
        }

        static public void ShowCommodities()
        {
            int i = 0;
            foreach (Commodity commodity in commodities)
            {
                Console.WriteLine(i + ". " + commodity.ToString());
                i++;
            }

        }

    }
}
