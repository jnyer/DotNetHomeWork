using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int N { get { return int.Parse(n_value.Text); } }
        double Len { get { return double.Parse(len_value.Text); } }
        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics!=null) graphics.Clear(this.BackColor);                     
            graphics = this.CreateGraphics();
            drawCarleyTree(N, 270, 350, Len, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 { get { return int.Parse(th_1_value.Text); } }
        double th2 { get { return int.Parse(th_2_value.Text); } }
        double per1 { get { return double.Parse(per_1_value.Text); } }
        double per2 { get { return double.Parse(per_2_value.Text); } }

        void drawCarleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCarleyTree(n - 1, x1, y1, per1 * leng, th + th1 * Math.PI / 180);
            drawCarleyTree(n - 1, x1, y1, per2 * leng, th - th2 * Math.PI / 180);
        }
        
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(new Pen(colorDialog1.Color), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }
        }
    }
}

