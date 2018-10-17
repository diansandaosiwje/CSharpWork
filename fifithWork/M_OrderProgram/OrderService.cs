using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class OrderService
    {
        private Dictionary<uint,Order> orderDict;          //改成dictionary了

        public void AddOrder(Order order)
        {
            if (orderDict.ContainsKey(order.Id))
                throw new Exception($"order-{order.Id} is already existed!");
            orderDict[order.Id] = order;
        }

        public void RemoveOrder(uint orderId)
        {
            orderDict.Remove(orderId);
        }

        public void ModifyOrder(Order order)
        {
            order.DeleteCommodity(CommodityList.commodities[1].Name);
            order.AddCommodity(new OrderDetail(CommodityList.commodities[0], 5));
            order.ChangeTheNumOfCommodity(order.OrderDetailsList[0].Commodity, 6);
        }

        public List<Order> SearchOrder(string commodityName)        //原来只返回查找的第一个值。。。。。改了
        {
            foreach(Order order in orderDict.Values)
            {
                var resultOrder = from orderDetails in order.OrderDetailsList where orderDetails.commodity.Name == commodityName select order;

                return resultOrder;
            }
            return null;
        }

        public Order SearchOrder(uint orderIDNumber)
        {
            return orderDict[orderIDNumber];
        }  
        
        public List<Order> SearchByCustomerName(string customerName)
        {
            var query = orderDict.Values
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

    }
}
