using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class Order
    {     
        public Order(int orderIDNumber,string customer,List<OrderDetails> orderDetails)
        {
            this.OrderIDNumber = orderIDNumber;
            this.Customer = customer;
            this.OrderDetailsList = orderDetails;
        }

        private int OrderIDNumber; 

        private string Customer;

        private List<OrderDetails> OrderDetailsList = new List<OrderDetails>();  
        
        public void AddCommodity(OrderDetails orderDetails)
        {
            this.OrderDetailsList.Add(orderDetails);
        }

    }
}
