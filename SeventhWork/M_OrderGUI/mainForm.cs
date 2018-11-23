using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M_OrderProgram;

namespace M_OrderGUI
{   
    public partial class mainForm : Form
    {
        OrderService orderService;
        BindingSource fieldsBS = new BindingSource();
        public mainForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            //客户
            Customer customer1 = new Customer(20181123, "Tom");
            Customer customer2 = new Customer(20185462, "Bob");
            Customer customer3 = new Customer(20184762, "Cindy");

            //添加几种商品
            CommodityList.AddCommodity(new Commodity("pencil", 1, 001));
            CommodityList.AddCommodity(new Commodity("pen", 10, 002));
            CommodityList.AddCommodity(new Commodity("cellPhone", 1000, 003));
            CommodityList.AddCommodity(new Commodity("pants", 100, 004));
            CommodityList.AddCommodity(new Commodity("skirt", 150, 005));

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


            orderService = new OrderService();
            //添加订单
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            this.orderBindingSource.DataSource = orderService.queryAllOrders();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Order());
            editForm.ShowDialog();

            Order newOrder = editForm.getResult();
            if (newOrder != null)
            {
                orderService.AddOrder(newOrder);
                orderBindingSource.DataSource = orderService.queryAllOrders();
            }
        }

        private void butModify_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm((Order)orderBindingSource.Current);
            editForm.ShowDialog();

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Order o = (Order)orderBindingSource.Current;
            if(o!=null)
            {
                orderService.RemoveOrder(o.Id);
                orderBindingSource.DataSource = orderService.queryAllOrders();
            }

        }

        private void butExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }

        }

        private void butImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result.Equals(DialogResult.OK))
            {
                string fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                orderBindingSource.DataSource = orderService.queryAllOrders();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           switch(comboBox1.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = orderService.queryAllOrders();
                    break;

                case 1:
                    uint id = 0;
                    uint.TryParse(textBox1.Text, out id);
                    orderBindingSource.DataSource = orderService.queryAllOrders();
                    break;

                case 2:
                    orderBindingSource.DataSource = orderService.GetByCustomerName(textBox1.Text);
                    break;
                case 3:
                    orderBindingSource.DataSource =
                        orderService.GetByCommodityName(textBox1.Text);
                    break;
                case 4:
                    double price = 0;
                    double.TryParse(textBox1.Text, out price);
                    orderBindingSource.DataSource = orderService.GetByPrice(price);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
