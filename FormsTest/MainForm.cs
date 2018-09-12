using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       



        private void caculateButton_Click(object sender, EventArgs e)
        {
            string numberX = NumberXText.Text;
            double x = Double.Parse(numberX);
            string numberY = NumberYText.Text;
            double y = Double.Parse(numberY);

            double productOfXY = x * y;
            ResultLabel.Text = "The product of " + x + " and " + y + " is: " + productOfXY;
        }
    }
}
