using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //客户
                Customer customer1 = new Customer(20181123, "Tom");
                Customer customer2 = new Customer(20185462, "Bob");
                Customer customer3 = new Customer(20184762, "Cindy");

                //添加几种商品
                CommodityList.AddCommodity(new Commodity("pencil", 1,001));
                CommodityList.AddCommodity(new Commodity("pen", 10,002));
                CommodityList.AddCommodity(new Commodity("cellPhone", 1000,003));
                CommodityList.AddCommodity(new Commodity("pants", 100,004));
                CommodityList.AddCommodity(new Commodity("skirt", 150,005));

                //订单明细实例，由商品组成
                OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
                OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
                OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);
                OrderDetail orderDetails4 = new OrderDetail(CommodityList.commodities[3], 6);
                OrderDetail orderDetails5 = new OrderDetail(CommodityList.commodities[4], 9);

                //实列化订单
                Order order1 = new Order(4, customer1);
                Order order2 = new Order(5, customer1);
                Order order3 = new Order(6, customer2);
                
                order1.AddCommodity(orderDetails1);
                order1.AddCommodity(orderDetails2);
                order2.AddCommodity(orderDetails2);
                order2.AddCommodity(orderDetails4);
                order3.AddCommodity(orderDetails3);
                order3.AddCommodity(orderDetails5);
                
                
                OrderService orderService = new OrderService();

                string fileName = "D:\\code\\C#\\CSharpWork\\sixthWork\\M_OrderProgram\\bin\\Debug\\OrderXmlFile.xml";

                orderService.Import(fileName);

                //添加订单
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                orderService.AddOrder(order3);

                orderService.Export();

                //移除订单
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
