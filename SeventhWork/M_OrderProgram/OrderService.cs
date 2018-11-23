using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace M_OrderProgram
{
    public class OrderService
    {
        public List<Order> orderList;         

        public OrderService()
        {
            orderList = new List<Order>();
        }

        public List<Order> queryAllOrders()
        {
            return orderList;
        }
        public void AddOrder(Order order)
        {
            if (orderList.Count == 0)
            {
                orderList.Add(order);
                return;
            }
            
            foreach (Order order1 in orderList)
            {
                if (order1.Id == order.Id)
                {
                    throw new Exception($"order-{order.Id} is already existed!");
                }
            }
            orderList.Add(order);
        }

        public void RemoveOrder(uint orderId)
        {
            foreach (Order order1 in orderList)
            {
                if (orderId == order1.Id)
                    orderList.Remove(order1);
                break;
             }
        }
        

        public List<Order> GetByCommodityName(string commodityName)        //原来只返回查找的第一个值。。。。。改了
        {
            var query = orderList.Where(order =>
              order.Details.Where(d => d.Commodity.Name == commodityName)
              .Count() > 0
          );
            return query.ToList();
        }

        public Order GetByOrderID(uint orderIDNumber)
        {
            Order order1 = new Order();
            foreach(Order order in orderList)
            {
                if (order.Id == orderIDNumber)
                    order1 = order;
                return order1;
            }
            throw new Exception ("There is no such id");         
        }  
        
        public List<Order> GetByCustomerName(string customerName)
        {
            var query = orderList.Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

        public List<Order> GetByPrice(double price)
        {
            var query = orderList.Where(order => order.Amount > price);
            return query.ToList();
        }

        public void Export(string filename="123.xml")
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            xmlser.Serialize(fs,this.orderList );
            fs.Close();
        }

        public void Import (string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);

            if (fs.Length == 0)
                throw (new Exception("The file is empty!"));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);

            foreach (Order order in orders)
            {
                orderList.Add(order);
            }
           
            fs.Close();
        }

    }
}
