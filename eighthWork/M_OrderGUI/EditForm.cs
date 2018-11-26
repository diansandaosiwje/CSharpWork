using M_OrderProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_OrderGUI
{
    public partial class EditForm : Form
    {
        Order result = null;

        public EditForm()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "customer1",15987263421);
            Customer customer2 = new Customer(2, "customer2",13985497512);

            Commodity commodity1 = new Commodity("pen", 2.0, 1);
            Commodity commodity2 = new Commodity("notebook", 1.0, 2);
            Commodity commodity3 = new Commodity("car", 10.0, 3);

            customerBindingSource.Add(customer1);
            customerBindingSource.Add(customer2);

            commodityBindingSource.Add(commodity1);
            commodityBindingSource.Add(commodity2);
            commodityBindingSource.Add(commodity3);

        }

        public Order getResult()
        {
            return result;
        }

        public EditForm(Order order):this()
        {
            orderBindingSource.DataSource = order;
        }
       

        private void EditForm_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = ((Order)orderBindingSource.Current).Customer;
            textBox1.Text = ((Order)orderBindingSource.Current).Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong u = 0;
                ulong.TryParse(textBox1.Text, out u);
               
                ((Order)orderBindingSource.Current).Id = u;
                result = (Order)orderBindingSource.Current;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Order)orderBindingSource.Current).Customer = (Customer)comboBox2.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderDetailBindingSource.Current==null)
            {
                orderDetailBindingSource.Add(new OrderDetail());
            }
            ((OrderDetail)orderDetailBindingSource.Current).Commodity = (Commodity)comboBox1.SelectedItem;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==1)
            {
                if(dataGridView1.CurrentCell.Value!=null)
                {
                    comboBox1.Text = dataGridView1.CurrentCell.Value.ToString();
                }

                Rectangle R = dataGridView1.GetCellDisplayRectangle(
                    dataGridView1.CurrentCell.ColumnIndex,
                    dataGridView1.CurrentCell.RowIndex, false);
                comboBox1.Location = new Point(dataGridView1.Location.X + R.X,
                    dataGridView1.Location.Y + R.Y);

                comboBox1.Width = R.Width;
                comboBox1.Height = R.Height;
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }
        }     
    }
}
