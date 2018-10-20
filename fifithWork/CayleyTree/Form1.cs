using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public int Degree1 { set; get; }
        public int Degree2 { set; get; }

        public double Percent1 { set; get; }
        public double Percent2 { set; get; }

        public double Leng { get; set; }

        public int NumOfBrunch { set; get; }

        BindingSource pens = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            Degree1 = 30; Degree2 = 20; Percent1 = 0.6; Percent2 = 0.7; Leng = 100;  NumOfBrunch = 10;
            pens.Add(new { Name = "黑色", Value = Pens.Black });
            pens.Add(new { Name = "绿色", Value = Pens.Green });
            pens.Add(new { Name = "红色", Value = Pens.Red });
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = pens;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";

            textBox1.DataBindings.Add("Text", this, "Degree1");
            textBox2.DataBindings.Add("Text", this, "Degree2");
            textBox3.DataBindings.Add("Text", this, "NumOfBrunch");
            textBox5.DataBindings.Add("Text", this, "Percent1");
            textBox6.DataBindings.Add("Text", this, "Percent2");
            textBox7.DataBindings.Add("Text", this, "Leng");
        }
        void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x1 - leng / 2 * Math.Cos(th);
            double y2 = y1 - leng / 2 * Math.Sin(th);

            graphics.DrawLine((Pen)comboBox1.SelectedValue,
                 (int)x0, (int)y0, (int)x1, (int)y1);

            DrawCayleyTree(n - 1, x1, y1, Percent1 * leng, th + Degree1*Math.PI/180);
            DrawCayleyTree(n - 1, x2, y2, Percent2 * leng, th - Degree2*Math.PI/180);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panel1.CreateGraphics();
            graphics.Clear(panel1.BackColor);
            DrawCayleyTree(NumOfBrunch, panel1.Width / 2, panel1.Height - 20, Leng, -Math.PI / 2);
        }
    }
}
