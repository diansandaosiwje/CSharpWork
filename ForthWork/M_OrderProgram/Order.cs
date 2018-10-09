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

        private int orderIDNumber; 
        public int OrderIDNumber
        {
            set
            {
                orderIDNumber = value;
            }
            get
            {
                return orderIDNumber;
            }
        }

        private string customer;
        public string Customer
        {
            set
            {
                customer = value;
            }
            get
            {
                return customer;
            }
        }

        public List<OrderDetails> OrderDetailsList = new List<OrderDetails>();  

        
        public void AddCommodity(OrderDetails orderDetails)
        {
            this.OrderDetailsList.Add(orderDetails);
        }

        public void DeleteCommodity(OrderDetails orderDetails)
        {
            this.OrderDetailsList.Remove(orderDetails);
        }

        public void ChangeTheCustomer(string customer)
        {
            this.Customer = customer;
        }

        public void ChangeTheNumOfCommodity(Commodity commodity,int num)
        {
            foreach (OrderDetails orderDetails in OrderDetailsList )
            {
                if(orderDetails.commodity==commodity)
                {
                    orderDetails.CommodityNum = num;
                }
            }
        }

      
    }
}
