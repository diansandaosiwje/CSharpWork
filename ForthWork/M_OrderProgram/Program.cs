﻿using System;
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
            CommodityList.AddCommodity( new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));
            CommodityList.AddCommodity(new Commodity("pants", 100));
            CommodityList.AddCommodity(new Commodity("skirt", 150));
            
            //订单明细实例，由商品组成
            OrderDetails orderDetails1 = new OrderDetails(CommodityList.commodities[0], 10);
            OrderDetails orderDetails2 = new OrderDetails(CommodityList.commodities[1], 5);
            OrderDetails orderDetails3 = new OrderDetails(CommodityList.commodities[2], 15);
            OrderDetails orderDetails4 = new OrderDetails(CommodityList.commodities[3], 6);
            OrderDetails orderDetails5 = new OrderDetails(CommodityList.commodities[4], 9);

            //订单明细组成订单
            List<OrderDetails> orderDetailsList1 = new List<OrderDetails> { orderDetails1, orderDetails2 };
            List<OrderDetails> orderDetailsList2 = new List<OrderDetails> { orderDetails1, orderDetails2,orderDetails5 };
            List<OrderDetails> orderDetailsList3 = new List<OrderDetails> { orderDetails2};
            List<OrderDetails> orderDetailsList4 = new List<OrderDetails> { orderDetails4, orderDetails3,orderDetails5 };

            //实列化订单
            Order order1 = new Order(1234567,"Tom",orderDetailsList1);
            Order order2 = new Order(12345,"Bob", orderDetailsList2);
            Order order3 = new Order(123002,"Alice", orderDetailsList3);
            Order order4 = new Order(123008,"Dare", orderDetailsList4);





        }
    }
}
