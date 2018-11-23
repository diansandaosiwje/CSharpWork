using Microsoft.VisualStudio.TestTools.UnitTesting;
using M_OrderProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        [TestMethod()]
        public void AddOrderTest()
        {
            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);


            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

            Assert.AreEqual(os.orderList.Count(), 3);
            Assert.AreEqual(os.orderList[0], order1);
            Assert.AreEqual(os.orderList[1], order2);
            Assert.AreEqual(os.orderList[2], order3);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);


            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

            os.RemoveOrder(1);
            Assert.AreEqual(os.orderList[0], order2);
            Assert.AreEqual(os.orderList[1], order3);
        }

        [TestMethod()]
        public void GetByCommodityNameTest()
        {
            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);

            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);


            List<Order> orders = os.GetByCommodityName("pencil");

            foreach (Order order0 in orders)
            {
                bool value = false;
                foreach (OrderDetail orderDetail in order0.OrderDetailsList)
                {
                    if (orderDetail.Commodity.Name == "pencil")
                        value = true;
                    break;
                }
                if (value == false) Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetByOrderIDTest()
        {

            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);


            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);


            Order order0 = os.GetByOrderID(1);
            Assert.AreEqual((uint)1, order0.Id);
        }

        [TestMethod()]
        public void GetByCustomerNameTest()
        {

            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);


            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

            List<Order> orders = os.GetByCustomerName(customer1.Name);
            foreach (Order order in orders)
            {
                Assert.AreEqual(order.Customer.Name, customer1.Name);
            }
        }

        [TestMethod()]
        public void ExportTest()
        {

            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1));
            CommodityList.AddCommodity(new Commodity("pen", 10));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000));

            //订单明细实例，由商品组成
            OrderDetail orderDetails1 = new OrderDetail(CommodityList.commodities[0], 10);
            OrderDetail orderDetails2 = new OrderDetail(CommodityList.commodities[1], 5);
            OrderDetail orderDetails3 = new OrderDetail(CommodityList.commodities[2], 15);


            //实列化订单
            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);

            order1.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails1);
            order2.AddCommodity(orderDetails2);
            order3.AddCommodity(orderDetails3);

            OrderService os = new OrderService();

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

          

        }
    }1+

}