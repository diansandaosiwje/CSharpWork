using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    [Serializable]
    public class Order
    {
        private List<OrderDetail> OrderDetailsList = new List<OrderDetail>(); 

        public Order()
        {
        }

        public List<OrderDetail>Details
        {
            get
            {
                return this.OrderDetailsList;
            }
        }

        public Order(uint orderIDNumber,Customer customer)
        {
            OrderDetailsList = new List<OrderDetail>();
            this.Id = orderIDNumber;
            this.Customer = customer;         
        }
     
        public uint Id { set; get; } //简化属性用法。。。。

        public Customer Customer { get; set; }

        public double Amount
        {
            get
            {
                return Details.Sum(d => d.Commodity.Price * d.Quantity);
            }
        }


        public void AddCommodity(OrderDetail orderDetails)
        {
            this.OrderDetailsList.Add(orderDetails);
        }

        public void DeleteCommodity(string commodityName)//删除条件改变
        {
            OrderDetailsList.RemoveAll(d=> d.Commodity.Name==commodityName );
        }
   

        public void ChangeTheNumOfCommodity(Commodity commodity,uint num)
        {
            foreach (OrderDetail orderDetails in OrderDetailsList )
            {
                if(orderDetails.Commodity==commodity)
                {
                    orderDetails.Quantity = num;
                }
            }
        }
      
    }
}
