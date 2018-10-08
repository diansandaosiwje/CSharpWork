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

        public void ModifyOrder() { }

        public Order SearchOrder(string orderName)
        {

            return  
        }

        public Order SearchOrder(int orderNumber)
        {

            return  
        }

        



    }
}
