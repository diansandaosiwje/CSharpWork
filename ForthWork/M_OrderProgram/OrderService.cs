using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class OrderService
    {
        private List<Order> orderLists = new List<Order>();

        public void AddOrder(Order order)
        {
            orderLists.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            orderLists.Remove(order);
        }

        public void ModifyOrder(Order order)
        {
            order.DeleteCommodity(order.OrderDetailsList[0]);
            order.AddCommodity(new OrderDetails(CommodityList.commodities[0], 5));
            order.ChangeTheCustomer("529pou");
            order.ChangeTheNumOfCommodity(order.OrderDetailsList[0].commodity, 6);



        }

        public Order SearchOrder(string commodityName)
        {
            foreach(Order order in orderLists)
            {
               foreach (OrderDetails orderDetails in order.OrderDetailsList)
                {
                    if(orderDetails.commodity.CommodityName==commodityName)
                    {
                        return order;

                    }
                }
            }
            return null;
        }

        public Order SearchOrder(int orderIDNumber)
        {
            foreach(Order order in orderLists)
            {
                if(order.OrderIDNumber==orderIDNumber)
                {
                    return order;
                }
            }
            return null;
        }    



    }
}
