using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));
            CommodityList.AddCommodity(new Commodity("pants", 100));
            CommodityList.AddCommodity(new Commodity("skirt", 150));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);
            OrderDetail orderDetails4 = new OrderDetail(CommodityList.commodities[3], 6);
            OrderDetail orderDetails5 = new OrderDetail(CommodityList.commodities[4], 9);

            //订单明细组成订单
            List<OrderDetail> orderDetailsList1 = new List<OrderDetail> { orderDetails1, orderDetails2 };
            List<OrderDetail> orderDetailsList2 = new List<OrderDetail> { orderDetails1, orderDetails2, orderDetails5 };
            List<OrderDetail> orderDetailsList3 = new List<OrderDetail> { orderDetails2 };
            List<OrderDetail> orderDetailsList4 = new List<OrderDetail> { orderDetails4, orderDetails3, orderDetails5 };

            //实列化订单
            Order order1 = new Order(1234567, "Tom", orderDetailsList1);
            Order order2 = new Order(12345, "Bob", orderDetailsList2);
            Order order3 = new Order(123002, "Alice", orderDetailsList3);
            Order order4 = new Order(123008, "Dare", orderDetailsList4);



            OrderService orderService = new OrderService();

            //添加订单
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            //删除订单
            orderService.DeleteOrder(order1);

            //修改订单
            orderService.ModifyOrder(order2);









        }
    }
}
